using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace EASCAN.UserControls
{
    public partial class UC_Profile : UserControl
    {
        string mycon = "datasource=localhost;username=root;password=;database=eascan_db;";
        public UC_Profile()
        {
            InitializeComponent();
        }


        private void UC_Profile_Load(object sender, EventArgs e)
        {
             {

             }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "insert into eascan_tbl(Name, Birthday, Address, Contact, Email,Age) values('" + this.label8.Text + "','" + this.label9.Text + "','" + this.label10.Text + "','" + this.label11.Text + "','" + this.label12.Text + "','" + this.label13.Text + "');";
                MySqlConnection mycon2 = new MySqlConnection(mycon);
                MySqlCommand mycommand = new MySqlCommand(query, mycon2);
                MySqlDataReader MyReader1;
                mycon2.Open();
                MyReader1 = mycommand.ExecuteReader();
                MessageBox.Show("Data is inserted");

                mycon2.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

       ///edit edit

    }
}
