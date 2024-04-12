using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using System;
using System.Data.Common;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using RegistrationAndLogin;

namespace InventoryApplication
{
    public partial class InventoryList : Form
    {
        private SqlDataAdapter dataAdapter = new SqlDataAdapter();
        private DataTable table = new DataTable();

        SqlCommand cmd;
        SqlConnection cn;
        SqlDataReader dr;

        public static bool isFormAdd = false;
        public static List<Object> updatePurchaseNo = new List<Object>();
        public static List<Object> deletePurchaseNo = new List<Object>();

        public InventoryList()
        {
            InitializeComponent();

        }

        private void InventoryList_Load(object sender, EventArgs e)
        {
            cn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Admin\Downloads\InventoryApplication\InventoryApplication\Database.mdf;Integrated Security=True");
            cn.Open();
            GetData();
        }


        private void GetData()
        {
            try
            { 
                dataAdapter = new SqlDataAdapter("select * from Inventory_List", cn);
                SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);
                table = new DataTable();
                dataAdapter.Fill(table);
                dataGridView1.DataSource = table;
                dataGridView1.Columns["Id"].Visible = false;
                dataGridView1.Columns["CreateManager"].Visible = false;
                DataGridViewButtonColumn updateButton = new DataGridViewButtonColumn();
                updateButton.FlatStyle = FlatStyle.Flat;
                updateButton.HeaderText = "Update";
                updateButton.Name = "Action";
                updateButton.UseColumnTextForButtonValue = true;
                updateButton.Text = "Update";
                dataGridView1.Columns.Add(updateButton);
                DataGridViewButtonColumn deleteButton = new DataGridViewButtonColumn();
                deleteButton.FlatStyle = FlatStyle.Flat;
                deleteButton.HeaderText = "Delete";
                deleteButton.Name = "Action";
                deleteButton.UseColumnTextForButtonValue = true;
                deleteButton.Text = "Delete";
                dataGridView1.Columns.Add(deleteButton);
                dataGridView1.AllowUserToAddRows = false;
                dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 9.75F, FontStyle.Bold);
            }
            catch (SqlException)
            {
                MessageBox.Show("SQL Error");
            }

        }

        private void updateDataGrid_InventoryList(object sender, DataGridViewCellEventArgs e)
        {
            //Update Action
            if (e.ColumnIndex == 10 && e.RowIndex != -1)
            {
                var selectedItem = table.Rows[e.RowIndex];
                isFormAdd = false;
                updatePurchaseNo = selectedItem.ItemArray.ToList();
                this.Hide();
                AddUpdateForm addUpdateForm = new AddUpdateForm();
                addUpdateForm.ShowDialog();
            }
            else if (e.ColumnIndex == 11 && e.RowIndex != -1)
            {
                var selectedItem = table.Rows[e.RowIndex];
                deletePurchaseNo = selectedItem.ItemArray.ToList();

                cn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Admin\Downloads\InventoryApplication\InventoryApplication\Database.mdf;Integrated Security=True");
                cn.Open();
                SqlTransaction transaction = cn.BeginTransaction();
                try
                {
                    SqlCommand cmd0 = new SqlCommand("select Quantity from Inventory_List where PurchaseNo = '" + deletePurchaseNo[9].ToString() + "'", cn, transaction);
                    SqlDataReader dr0 = cmd0.ExecuteReader();
                    float existsQuantity = 0;
                    while (dr0.Read())
                    {
                        existsQuantity = float.Parse(dr0[0].ToString());
                    }
                    cmd0.Dispose();
                    dr0.Dispose();

                    SqlCommand cmd1 = new SqlCommand("select Quantity from Item_List where Code = '" + deletePurchaseNo[6].ToString() + "'", cn, transaction);
                    SqlDataReader dr1 = cmd1.ExecuteReader();
                    float existsItemQuantity = 0;
                    while (dr1.Read())
                    {
                        existsItemQuantity = float.Parse(dr1[0].ToString());
                    }
                    cmd1.Dispose();
                    dr1.Dispose();

                    float checkValue = (existsItemQuantity - existsQuantity);

                    if (checkValue < 0)
                    {
                        MessageBox.Show("Deleting purchase item is less than inventory stock.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }

                    SqlCommand cmd2 = new SqlCommand("Delete Inventory_List where PurchaseNo = '" + deletePurchaseNo[9].ToString() + "'", cn, transaction);
                    cmd2.ExecuteNonQuery();
                    cmd2.Dispose();

                    SqlCommand cmd3 = new SqlCommand("Update Item_List set Quantity = '" + checkValue + "' where Code = '" + deletePurchaseNo[6].ToString() + "'", cn, transaction);
                    cmd3.ExecuteNonQuery();
                    cmd3.Dispose();

                    transaction.Commit();
                    MessageBox.Show("Purchase has deleted successfully.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Hide();
                    InventoryList inventoryList = new InventoryList();
                    inventoryList.ShowDialog();
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show(ex.ToString());
                }
            }
        }
       
        private void btnSearch_Click(object sender, EventArgs e)
        {
            // dataGridView1.Filter = "YourColumn LIKE '%" + txtSearch.Text + "%"";
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            //dataGridView1.DefaultView.Sort = "YourColumn ASC";
        }


        private void Btn_Add(object sender, EventArgs e)
        {
            this.Hide();
            isFormAdd = true;
            updatePurchaseNo = new List<object>();
            AddUpdateForm addUpdateForm = new AddUpdateForm();
            addUpdateForm.ShowDialog();
        }

        private void labelTitle_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnStock_Click(object sender, EventArgs e)
        {
            this.Hide();
            StockList stockList = new StockList();
            stockList.ShowDialog();
        }

        private void btnBilling_Click(object sender, EventArgs e)
        {
            this.Hide();
            BillingList billingList = new BillingList();
            billingList.ShowDialog();
        }
    }
}