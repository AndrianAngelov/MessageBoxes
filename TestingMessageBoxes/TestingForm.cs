using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Anyo.WindowsForms.MessageBoxes;

namespace TestingMessageBoxes
{
    public partial class TestingForm : Form
    {
        //string longStr = "longlonglonglonglonglonglonglonglonglonglonglonglonglonglonglonglonglonglonglonglonglonglonglonglonglonglonglonglonglonglonglonglonglonglonglonglonglonglonglonglonglonglonglonglonglonglonglonglonglonglonglonglonglonglonglonglonglonglonglonglonglonglonglonglonglonglonglonglonglonglonglonglonglonglonglonglonglonglonglonglonglonglonglonglonglonglonglonglonglonglonglonglonglonglonglonglonglonglonglonglonglonglonglonglonglonglonglonglonglonglonglonglonglonglonglonglonglonglonglonglonglonglonglonglonglonglonglonglonglonglonglonglonglonglonglonglonglonglonglonglonglonglonglonglonglonglonglonglonglonglonglonglonglonglonglonglonglonglonglonglonglonglonglonglonglonglonglonglonglonglonglonglonglonglonglonglonglonglonglonglonglonglonglonglonglonglonglonglonglonglonglonglonglonglonglonglonglonglonglonglonglonglonglonglonglonglonglonglonglonglonglonglonglonglonglonglonglonglonglonglonglonglonglonglonglonglonglonglonglonglonglonglonglonglonglonglonglonglonglonglonglonglonglonglonglonglonglonglonglonglong";
        //string shortStr = "shortshortshortshortshortshortshortshortshortshort01234567890123";

        public TestingForm()
        {
            InitializeComponent();
        }

        private void show_btn_Click(object sender, EventArgs e)
        {
            object o2 = null;
            try
            {
                int i2 = (int)o2;
            }
            catch (Exception ex)
            {
                SampleMessageBox.Show(ex.Message);
                //SampleMessageBox.Show(ex.Message + "\n" + ex.Message + "\n" + ex.Message + "\n" + ex.Message + "\n" + ex.Message + "\n" + ex.Message + "\n" + ex.Message);
            }
            //SampleMessageBox.Show(shortStr);
            //SampleMessageBox.Show(longStr);
        }

        private void TestingForm_Load(object sender, EventArgs e)
        {

        }
    }
}
