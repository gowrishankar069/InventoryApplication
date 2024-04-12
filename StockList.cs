using InventoryApplication;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Forms;

namespace RegistrationAndLogin
{
    public partial class StockList : Form
    {
        private SqlDataAdapter dataAdapter = new SqlDataAdapter();
        private DataTable table = new DataTable();

        SqlConnection cn;

        public StockList()
        {
            InitializeComponent();
        }

        private void StockList_Load(object sender, EventArgs e)
        {

            cn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Admin\Downloads\InventoryApplication\InventoryApplication\Database.mdf;Integrated Security=True");
            cn.Open();
            GetData();
        }


        private void GetData()
        {
            try
            {
                dataAdapter = new SqlDataAdapter("select * from Item_List", cn);
                SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);
                table = new DataTable();
                dataAdapter.Fill(table);
                dataGridStockView1.DataSource = table;
                dataGridStockView1.Columns["Id"].Visible = false;
                dataGridStockView1.AllowUserToAddRows = false;
                dataGridStockView1.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 9.75F, FontStyle.Bold);

            }
            catch (SqlException)
            {
                MessageBox.Show("SQL Error");
            }

        }

        private void dataGridStockView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnViewInventory_Click(object sender, EventArgs e)
        {
            this.Hide();
            InventoryList inventoryList = new InventoryList();
            inventoryList.ShowDialog();
        }
    }
}
