using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Across_the_Globe_Guide.Forms
{
    public partial class AboutForm : Form
    {
        public AboutForm()
        {
            InitializeComponent();
        }

        private static bool mainFormOpened = false;
        private void mainpageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!mainFormOpened)
            {
                var mainForm = new MainForm();
                mainForm.Show();
                mainFormOpened = true;
            }
        }
    }
}
