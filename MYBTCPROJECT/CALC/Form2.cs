using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CALC
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public Form2(string windowsTitle, string message)
        {
            InitializeComponent();
            this.Text = windowsTitle;
            lblpassword.Text = message;
            this.ActiveControl = txtbpsw;

        }
        public static string Show(string windowstitle, string message)
        {
            using (Form2 inputDlg = new Form2(windowstitle, message))
            {
                inputDlg.ShowDialog();
                return inputDlg.txtbpsw.Text;
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void Form2_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
            }
        }
    }
}
