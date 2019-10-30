using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LogLibrary;
using static System.Configuration.ConfigurationManager;

namespace GeneralExperimentsWithTrace
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void GetListenerPropertiesButton_Click(object sender, EventArgs e)
        {
            /*
             * Read from app.config
             */
            SideTraceListener.Instance.CreateLog(AppSettings["SidesListenerLogName"],AppSettings["SidesListenerName"]);

            /*
             * Get log file name and listener name.
             * Commenting out the line above does not break these next lines
             */
            Console.WriteLine(SideTraceListener.Instance.ListenerLogFileName());
            Console.WriteLine(SideTraceListener.Instance.ListenerName());

        }
    }
}
