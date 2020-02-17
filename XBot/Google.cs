using ExcelUtils;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using XBot;
using Cookie = System.Net.Cookie;
using Size = System.Drawing.Size;

namespace GPwdBot
{
    public class Google : IGoogle
    {       
        private string m_initialAddress = "http://www.stockhouse.com/";
        public bool m_status_ok = true;
        DataTable m_main_dt;
        int dur = 10;
        int interval = 15;
        System.Windows.Forms.Timer m_timer = new System.Windows.Forms.Timer();
        public Google(DataTable dt, int during, int inter)
        {
            finish_work("ok", true);
            m_timer = new System.Windows.Forms.Timer();
            m_timer.Start();
            m_main_dt = dt;
            dur = during;
            interval = inter;
        }

        public void finish_work(string msg, bool ok = false)
        {
            try
            {      
                Quit();
                m_timer.Stop();
            }
            catch (Exception ex)
            {
                MainApp.log_info(ex.Message + "\n" + ex.StackTrace);
            }
        }

        public async void work_flow()
        {
            
            MainApp.m_main_frm.setRemain(m_main_dt.Rows.Count);
            string xpath = "";
            //if (MainApp.first == 0)
            {
                //Google Browser Start
                if (!await Start())
                {
                    finish_work("Chrome starting failed");
                    return;
                }

                MainApp.first = 1;


                //Set Cookie
                await Navigate("http://www.stockhouse.com");
                xpath = "//*/input[@value='Accept cookies']";
                await WaitToPresent(xpath, 3000);
                await TryClick(xpath, 2);
            }
            //Get Data
            for (int i = 0; i < m_main_dt.Rows.Count; i++)
            {
                try
                {
                    MainApp.m_main_frm.setRemain(m_main_dt.Rows.Count - i);
                    string val = m_main_dt.Rows[i]["name"].ToString();

                    
                    //Goto url
                    await Navigate("http://www.stockhouse.com/companies/quote?symbol=" + val);
                    Driver.SwitchTo().DefaultContent();

                    //switch iframe element
                    xpath = "(//*/iframe[contains(@data-src,'www.stockhouse.com/cmspages/iframes/morningstar.aspx')])[2]";
                    Driver.SwitchTo().Frame(Driver.FindElementByXPath(xpath));
                    xpath = "(//*/iframe[@id='QSAPI_IFRAME_0'])";
                    Driver.SwitchTo().Frame(Driver.FindElementByXPath(xpath));

                    xpath = "//*/a[@value='minute30']";
                    await WaitToPresent(xpath, 3000);
                    //string valdd = Driver.FindElementByXPath(indicator_xpath).GetAttribute("innerText");
                    await TryClick(xpath, 0);

                    Thread.Sleep(2000);

                    xpath = "//*/a[@value='indicators']";
                    await WaitToPresent(xpath, 3000);
                    //string valdd = Driver.FindElementByXPath(indicator_xpath).GetAttribute("innerText");
                    await TryClick(xpath, 2);                    

                    xpath = "//*/a[@value='RSI']";
                    await WaitToPresent(xpath, 3000);
                    await TryClick(xpath, 2);

                    Thread.Sleep(100);

                    xpath = "//*/a[@value='draw']";
                    await WaitToPresent(xpath, 3000);
                    await TryClick(xpath, 2);

                    Thread.Sleep(100);

                    xpath = "((//*/div[@name='RSI']/div)[2]/div)";
                    await WaitToPresent(xpath, 3000);
                    var element = Driver.FindElementByXPath(xpath).FindElements(By.TagName("div"));

                    Thread.Sleep(100);

                    xpath = "((//*/div[@name='RSI']/div)[2]/div/div)[" + (element.Count-1) + "]";
                    await WaitToPresent(xpath, 3000);
                    string rsi_val = Driver.FindElementByXPath(xpath).GetAttribute("innerText");

                    //back to main frame
                    Driver.SwitchTo().DefaultContent();

                    //select first iframe
                    xpath = "(//*/iframe[contains(@data-src,'www.stockhouse.com/cmspages/iframes/morningstar.aspx')])[1]";
                    Driver.SwitchTo().Frame(Driver.FindElementByXPath(xpath));
                    xpath = "(//*/iframe[@id='QSAPI_IFRAME_0'])";
                    Driver.SwitchTo().Frame(Driver.FindElementByXPath(xpath));

                    //get last price
                    xpath = "//*/span[@domid='LastPrice']";
                    await WaitToPresent(xpath, 3000);
                    string last_price_val = Driver.FindElementByXPath(xpath).GetAttribute("innerText");

                    //get day change
                    xpath = "(//*/span[@domid='Chg'])[2]";
                    await WaitToPresent(xpath, 3000);
                    string day_change_val = Driver.FindElementByXPath(xpath).GetAttribute("innerText");

                    //get 52wk high value
                    xpath = "//*/div[@rowid='High52W']/div[3]/div";
                    await WaitToPresent(xpath, 3000);
                    string wk_high = Driver.FindElementByXPath(xpath).GetAttribute("innerText");

                    //get 52wk low value
                    xpath = "//*/div[@rowid='Low52W']/div[3]/div";
                    await WaitToPresent(xpath, 3000);
                    string wk_low = Driver.FindElementByXPath(xpath).GetAttribute("innerText");

                    float b_val = float.Parse(rsi_val, CultureInfo.InvariantCulture.NumberFormat);
                    float c_val = float.Parse(last_price_val, CultureInfo.InvariantCulture.NumberFormat);
                    float d_val = float.Parse(day_change_val, CultureInfo.InvariantCulture.NumberFormat);
                    float e_val = float.Parse(wk_high, CultureInfo.InvariantCulture.NumberFormat);
                    float f_val = float.Parse(wk_low, CultureInfo.InvariantCulture.NumberFormat);
                    float g_val = (e_val - f_val) / c_val;
                    float h_val = g_val / b_val;
                    Driver.SwitchTo().Window(Driver.WindowHandles.First());

                    //set grid                    
                    m_main_dt.Rows[i][1] = b_val;
                    m_main_dt.Rows[i][2] = c_val;
                    m_main_dt.Rows[i][3] = d_val;
                    m_main_dt.Rows[i][4] = e_val;
                    m_main_dt.Rows[i][5] = f_val;
                    m_main_dt.Rows[i][6] = g_val;
                    m_main_dt.Rows[i][7] = h_val;

                    MainApp.m_main_dt = m_main_dt;
                    MainApp.m_main_frm.refresh();
                    Thread.Sleep(dur*1000);
                }
                catch(Exception ex)
                {

                }
            }

            MainApp.m_main_frm.setRemain(0);


            //Save Excel
            String g = DateTime.Now.ToString("yyyy-MM-dd-hh-mm-ss") + ".xls";
            ExcelUtil.SaveDataExcel(MainApp.m_main_dt, g, "Sheet1");


            finish_work("ok", true);

            Thread.Sleep(interval * 60 * 1000);

            //Set Grid
            MainApp.m_main_dt = m_main_dt;
            MainApp.m_main_frm.refresh_grid();            
        }
    }
}
