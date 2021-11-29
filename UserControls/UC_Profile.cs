using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;


namespace EASCAN.UserControls
{
    public partial class UC_Profile : UserControl
    {
        string mycon = "datasource=localhost;username=root;password=;database=eascan_db;";
        public UC_Profile()
        {
            InitializeComponent();
        }

<<<<<<< HEAD
        private void UC_Profile_Load(object sender, EventArgs e)
        {

        }
=======
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "insert into eascan_tbl(Name,Birthday,Address,Contact,Email,Age) values('" + this.textBox1.Text + "','" + this.textBox2.Text + "','" + this.textBox3.Text + "','" + this.textBox4.Text + "','" + this.textBox5.Text + "','" + this.textBox6.Text + "');";
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
>>>>>>> 6a787e1139be932e067cb2898ea07290a016ab6f
    }
}
