using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace EASCAN.UserControls
{
    public partial class UC_Dashboard : UserControl
    {
        string mycon = "datasource=localhost;username=root;password=database=eascan_db;";
        public UC_Dashboard()
        {
            InitializeComponent();
        }

        private void UC_Dashboard_Load(object sender, EventArgs e)
        {
            try
            {
                string query = "Select * from eascan";
                MySqlConnection mycon2 = new MySqlConnection(mycon);
                MySqlCommand mycommand = new MySqlCommand(query, mycon2);
                MySqlDataAdapter myadapter = new MySqlDataAdapter();
                myadapter.SelectCommand = mycommand;
                DataTable dtable = new DataTable();
                myadapter.Fill(dtable);
                dataGridView1.DataSource = dtable;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

