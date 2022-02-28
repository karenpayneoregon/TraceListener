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
using FileOperations;
using LogLibrary;

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
             * Initialed logger in Program class
             */

            var fileOperations = new Reader();
            fileOperations.GetLines();

        }

        private void CastingButton_Click(object sender, EventArgs e)
        {
            try
            {
                SideTraceListener.Instance.Info("Before bad cast");
                var CheckBox = (CheckBox)sender;
            }
            catch (Exception exception)
            {
                SideTraceListener.Instance.Exception(exception);
            }

        }
    }
}
