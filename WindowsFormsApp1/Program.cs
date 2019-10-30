using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace WindowsFormsApp1
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            XmlOlvasas();
        }

        static void XmlOlvasas()
        {
            XmlDocument dokument = new XmlDocument();
            dokument.Load("mod.xml");
            foreach (XmlNode item in dokument.DocumentElement)
            {
                if (item.InnerText == "normal")
                {
                    Application.Run(new Form1());
                    
                }
                else if (item.InnerText == "admin")
                {
                    Application.Run(new Form2());
                }
                
            }
        }
    }
}
