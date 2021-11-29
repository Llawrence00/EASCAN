using System;
using System.Windows.Forms;

namespace EASCAN
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void txt_User_TextChanged(object sender, EventArgs e)
        {

        }
        private void txt_Pass_TextChanged(object sender, EventArgs e)
        {

        }
        private void chk_Show_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_Show.Checked)
            {
                txt_Pass.PasswordChar = '\0';
            }
            else
            {
                txt_Pass.PasswordChar = '•';
            }
        }
        private void bttn_Login_Click(object sender, EventArgs e)
        {
            new Form2().Show();
            this.Hide();
        }

        private void bttn_Clear_Click(object sender, EventArgs e)
        {
            txt_User.Text = "";
            txt_Pass.Text = "";
            txt_User.Focus();
        }
    }
}
