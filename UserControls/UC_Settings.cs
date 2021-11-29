using System;
using System.Windows.Forms;

namespace EASCAN.UserControls
{
    public partial class UC_Settings : UserControl
    {
        public UC_Settings()
        {
            InitializeComponent();
        }

        //Email Notification
        private void bttn_en_1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Notificatioin changes has been successfully saved!!");
        }
        private void bttn_en_0_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Notificatioin changes has been successfully saved!!");
        }

        //Text Notification
        private void bttn_tn_1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Notificatioin changes has been successfully saved!!");
        }

        private void bttn_tn_0_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Notificatioin changes has been successfully saved!!");
        }

        //Clear Data
        private void bttn_cleardata_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Please Login your Account!!");
            Form2.ActiveForm.Close();
            new Form1().Show();

        }
    }
}
