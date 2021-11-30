using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace EASCAN.UserControls
{
    public partial class UC_Dashboard : UserControl
    {
        string mycon = "datasource=localhost;username=root;password=;database=eascan_db;";
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
        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                lblTime.Text = row.Cells["Time"].Value.ToString();
                lblDate.Text = row.Cells["Date"].Value.ToString();
                lblTemp.Text = row.Cells["Temperature"].Value.ToString();
                lblMask.Text = row.Cells["Mask"].Value.ToString();
                lblDay.Text = row.Cells["Day"].Value.ToString();
            }
        }
    }
}

