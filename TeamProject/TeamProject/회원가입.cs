using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace TeamProject
{
    public partial class NewInfo : Form
    {

        public NewInfo()
        {
            InitializeComponent();
            this.ActiveControl = NewInfo_Text_Id;  
//dddddddddddddddddddddddddddddddddddddd
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void NewInfo_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void NewInfo_Load(object sender, EventArgs e)
        {

        }
    }
}
