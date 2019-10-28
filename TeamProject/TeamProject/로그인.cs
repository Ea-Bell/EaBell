using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeamProject
{
    public partial class LogInForm : Form
    {
        public LogInForm()
        {

            InitializeComponent();
            this.ActiveControl = LogInForm_Text_ID;

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Submit_Button_Click(object sender, EventArgs e)
        {
            NewInfo newInfo = new NewInfo();
            newInfo.ShowDialog();
        }
    }
}
