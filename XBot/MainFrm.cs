using ExcelUtils;
using GPwdBot;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Threading;

namespace XBot
{
    public partial class MainFrm : Form
    {
        string m_main_csv;
        DataTable m_main_dt;
        
        public MainFrm()
        {
            InitializeComponent();
        }

        private void btn_open_main_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dlg = new OpenFileDialog();
                dlg.Title = "Open Excel file";
                dlg.Filter = "Excel files|*.XLS|All files|*.*";
                dlg.InitialDirectory = Directory.GetCurrentDirectory();
                if (dlg.ShowDialog() == DialogResult.OK)
                {                    
                    txt_main_csv.Text = dlg.FileName;
                    fill_grid();
                }

                start();
                btn_open_main.Enabled = false;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message + "\n" + ex.StackTrace);
            }
        }
        public void start()
        {
            Thread t = new Thread(new ThreadStart(ThreadProc));
            if (t.IsAlive)
                t.Abort();
            t.Start();
        }

        public void ThreadProc()
        {
            int during = 10;
            int interval = 15;
            try
            {
                during = Convert.ToInt32(textBox1.Text);
                interval = Convert.ToInt32(textBox2.Text);
            }
            catch (Exception ex)
            {

            }
            Google goo = new Google(m_main_dt, during, interval);
            goo.work_flow();            
        }

        void fill_grid()
        {
            try
            {
                grid_main.Rows.Clear();

                m_main_csv = txt_main_csv.Text;
                m_main_dt = ExcelUtil.ReadDataExcel(m_main_csv,"");
                bind_main.DataSource = m_main_dt;

                for(int i=0; i<m_main_dt.Rows.Count; i++)
                {
                    grid_main.Rows.Add((i+1), m_main_dt.Rows[i]["name"], "", "", "", "", "", "", "");
                    grid_main.Rows[i].DefaultCellStyle.Font = new Font("Segoe UI", 10);
                }                
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Master XLS file format is not valid. {ex.Message}");
            }
        }

        public void refresh_grid()
        {
            this.InvokeOnUiThreadIfRequired(() =>
            {
                grid_main.Rows.Clear();
                for (int i = 0; i < MainApp.m_main_dt.Rows.Count; i++)
                {
                    grid_main.Rows.Add((i + 1), MainApp.m_main_dt.Rows[i]["name"], MainApp.m_main_dt.Rows[i][1], MainApp.m_main_dt.Rows[i][2], MainApp.m_main_dt.Rows[i][3], MainApp.m_main_dt.Rows[i][4], MainApp.m_main_dt.Rows[i][5], MainApp.m_main_dt.Rows[i][6], MainApp.m_main_dt.Rows[i][7]);
                }

                label2.Text = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss tt");

                int during = 10;
                int interval = 15;
                try
                {
                    during = Convert.ToInt32(textBox1.Text);
                    interval = Convert.ToInt32(textBox2.Text);
                }
                catch (Exception ex)
                {

                }
                start();
            });
        }

        public void refresh()
        {
            this.InvokeOnUiThreadIfRequired(() =>
            {
                grid_main.Rows.Clear();
                for (int i = 0; i < MainApp.m_main_dt.Rows.Count; i++)
                {
                    grid_main.Rows.Add((i + 1), MainApp.m_main_dt.Rows[i]["name"], MainApp.m_main_dt.Rows[i][1], MainApp.m_main_dt.Rows[i][2], MainApp.m_main_dt.Rows[i][3], MainApp.m_main_dt.Rows[i][4], MainApp.m_main_dt.Rows[i][5], MainApp.m_main_dt.Rows[i][6], MainApp.m_main_dt.Rows[i][7]);
                }
            });
        }

        public void setRemain(int count)
        {
            this.InvokeOnUiThreadIfRequired(() => {
                lab_remain.Text = count.ToString();
            });
        }

        public void OutputLog(string log)
        {
            this.InvokeOnUiThreadIfRequired(() =>
            {
                string log_ = DateTime.Now.ToString("tt hh:mm:ss - ") + " " + log;
                lab_status.Text = log_;
            });
        }
    }
}
