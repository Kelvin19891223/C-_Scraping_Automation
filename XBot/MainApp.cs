using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XBot
{
    static class MainApp
    {
        public static int first = 0;
        public static System.Object g_locker = new object();
        public static log4net.ILog logger = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        public static MainFrm m_main_frm = null;
        public static DataTable m_main_dt;
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            m_main_frm = new MainFrm();
            Application.Run(m_main_frm);
        }

        public static void log_info(string msg)
        {
            lock (g_locker)
            {
                try
                {
                    logger.Info(msg);
                    if (m_main_frm != null)
                    {
                        m_main_frm.OutputLog(msg);
                        string fname = "Log_shown.txt";
                        while (file_writable(fname) == false) ;
                        File.AppendAllLines(fname, new string[] { DateTime.Now.ToString("HH:mm:ss ") + msg });
                    }
                }
                catch (Exception ex)
                {

                }
            }
        }

        public static bool file_writable(string file)
        {
            try
            {
                using (Stream stream = new FileStream(file, FileMode.Append))
                {
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }
    }
}
