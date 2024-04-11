using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryApplication
{
    public partial class BillingList : Form
    {
        private SqlDataAdapter dataAdapter = new SqlDataAdapter();
        private DataTable table = new DataTable();

        SqlCommand cmd;
        SqlConnection cn;
        SqlDataReader dr;

        public BillingList()
        {
            InitializeComponent();
        }

        private void BillingList_Load(object sender, EventArgs e)
        {
            cn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Admin\Downloads\InventoryApplication\InventoryApplication\Database.mdf;Integrated Security=True");
            cn.Open();
            GetData();
        }


        private void GetData()
        {
            try
            {
                dataAdapter = new SqlDataAdapter("select * from Billing_List", cn);
                SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);
                table = new DataTable();
                dataAdapter.Fill(table);
                dataGridBillView1.DataSource = table;
                dataGridBillView1.Columns["Id"].Visible = false;
                dataGridBillView1.AllowUserToAddRows = false;
                dataGridBillView1.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 9.75F, FontStyle.Bold);

            }
            catch (SqlException)
            {
                MessageBox.Show("SQL Error");
            }

        }


        private void dataGridBillView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
