using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EASCAN.UserControls;
using MySql.Data.MySqlClient;



namespace EASCAN
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panel_body.Controls.Clear();
            panel_body.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void bttn_dashboard_Click(object sender, EventArgs e)
        {
            UC_Dashboard uc = new UC_Dashboard();
            addUserControl(uc);
        }

        private void bttn_profile_Click(object sender, EventArgs e) 
        {
            UC_Profile uc = new UC_Profile();
            addUserControl(uc);
        }

        private void bttn_settings_Click(object sender, EventArgs e)
        {
            UC_Settings uc = new UC_Settings();
            addUserControl(uc);
        }

        private void bttn_logout_Click(object sender, EventArgs e)
        {
            Form2.ActiveForm.Close();
            new Form1().Show();
        }
    }
}


/// Nakapasok na ako Kirbe to 