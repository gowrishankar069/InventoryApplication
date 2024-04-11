using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using System;
using System.Linq;
using System.Data.Common;
using InventoryApplication;
using System.Collections.Generic;
using System.Drawing;

namespace InventoryApplication
{
    public partial class AddUpdateForm : Form
    {

        SqlConnection con;
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter ada = new SqlDataAdapter();
        DataTable dt = new DataTable();
        SqlDataReader dr;

        public static bool pageLoad = false;

        public AddUpdateForm()
        {
            InitializeComponent();
        }

        private void hideLoginManager()
        {
            labelItem.Hide();
            itemValue.Hide();
            labelType.Hide();
            typeValue.Hide();
            labelProductName.Hide();
            productNameValue.Hide();

            labelTitle.Text = "Billing";
            labelPurchaseNo.Text = "Bill No";

            labelProductCode.Location = new System.Drawing.Point(163, 169);
            productCodeValue.Location = new System.Drawing.Point(356, 166);
            labelQuantity.Location = new System.Drawing.Point(163, 221);
            quantityValue.Location = new System.Drawing.Point(356, 221);
            btnAddUpdate.Location = new System.Drawing.Point(256, 305);
            btnViewInventory.Location = new System.Drawing.Point(230, 355);

            productCodeValue.ReadOnly = false;
            btnAddUpdate.Text = "Bill";
            btnViewInventory.Text = "View Billing";
        }

        private void showLoginManager()
        {
            labelItem.Show();
            itemValue.Show();
            labelType.Show();
            typeValue.Show();
            labelProductName.Show();
            productNameValue.Show();
            btnViewInventory.Text = "View Inventory";
            productCodeValue.ReadOnly = true;
            labelPurchaseNo.Text = "Purchase No";
            btnAddUpdate.Text = "Add";
        }

        private void AddUpdateForm_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Admin\Downloads\InventoryApplication\InventoryApplication\Database.mdf;Integrated Security=True");
            con.Open();
            if (!Login.isManager)
            {
                hideLoginManager(); 
            }
            else
            {
                showLoginManager();
                cmd.Connection = con;
                cmd.CommandText = "select * from Item_List";
                ada.SelectCommand = cmd;
                ada.Fill(dt);

                itemValue.Items.Clear();
                typeValue.Items.Clear();
                productNameValue.Items.Clear();

                pageLoad = true;
                var itemOption = dt.AsEnumerable().Select(row => row["Item"]).Distinct().ToList();
                foreach (string item in itemOption)
                {
                    itemValue.Items.Add(item);
                }

                if (itemOption.Count > 0)
                {
                    itemValue.Text = itemValue.Items[0].ToString();
                    var typeOption = (from r in dt.AsEnumerable()
                                      where r.Field<string>("Item") == itemValue.Items[0].ToString()
                                      select r["Type"]).Distinct().ToList();

                    foreach (string item in typeOption)
                    {
                        typeValue.Items.Add(item);
                    }

                    var itemName = itemValue.Items[0].ToString();
                    var typeName = typeValue.Items[0].ToString();

                    if (typeOption.Count > 0)
                    {
                        typeValue.Text = typeName;
                        var productNameOption = (from r in dt.AsEnumerable()
                                                 where r.Field<string>("Item") == itemName
                                                 where r.Field<string>("Type") == typeName
                                                 select r["ProductName"]).Distinct().ToList();
                        foreach (string item in productNameOption)
                        {
                            productNameValue.Items.Add(item);
                        }


                        if (productNameValue.Items.Count > 0)
                        {
                            var productName = productNameValue.Items[0].ToString();
                            productNameValue.Text = productName;
                            var selectProductCode = (from r in dt.AsEnumerable()
                                                     where r.Field<string>("Item") == itemName
                                                     where r.Field<string>("Type") == typeName
                                                     where r.Field<string>("ProductName") == productName
                                                     select r["Code"]).Distinct().ToList();

                            if (selectProductCode.Count > 0)
                            {
                                productCodeValue.Text = selectProductCode[0].ToString();
                                productCodeValue.ReadOnly = true;
                            }

                            if (InventoryList.isFormAdd)
                            {
                                purchaseNoValue.ReadOnly = false;
                                itemValue.Enabled = true;
                                typeValue.Enabled = true;
                                productNameValue.Enabled = true;
                                productCodeValue.ReadOnly = true;
                                pageLoad = false;
                                labelTitle.Text = "Add Purchase";
                                btnAddUpdate.Text = "Add";
                            }
                            else
                            {
                                dateValue.Text = InventoryList.updatePurchaseNo[1].ToString();
                                purchaseNoValue.Text = InventoryList.updatePurchaseNo[9].ToString();
                                itemValue.Text = InventoryList.updatePurchaseNo[3].ToString();
                                typeValue.Text = InventoryList.updatePurchaseNo[4].ToString();
                                productNameValue.Text = InventoryList.updatePurchaseNo[5].ToString();
                                productCodeValue.Text = InventoryList.updatePurchaseNo[6].ToString();
                                quantityValue.Text = InventoryList.updatePurchaseNo[7].ToString();
                                purchaseNoValue.ReadOnly = true;
                                itemValue.Enabled = false;
                                typeValue.Enabled = false;
                                productNameValue.Enabled = false;
                                productCodeValue.ReadOnly = true;
                                labelTitle.Text = "Update Purchase";
                                btnAddUpdate.Text = "Update";
                            }
                        }
                    }
                }
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.ShowDialog();
        }

        private void itemValue_TextChanged(object sender, EventArgs e)
        {
            if(!pageLoad)
            {
                var selectItem = itemValue.Text;
                typeValue.Items.Clear();
                productNameValue.Items.Clear();

                productCodeValue.Text = "";
                var typeOption = (from r in dt.AsEnumerable()
                                  where r.Field<string>("Item") == selectItem.ToString()
                                  select r["Type"]).Distinct().ToList();
                foreach (string item in typeOption)
                {
                    typeValue.Items.Add(item);
                }
                typeValue.SelectedIndex = 0;
            }
        }

        private void typeValue_TextChanged(object sender, EventArgs e)
        {
            if (!pageLoad)
            {
                var selectItem = itemValue.Text;
                var selectType = typeValue.Text;
                productNameValue.Items.Clear();
                productCodeValue.Text = "";
                var productNameOption = (from r in dt.AsEnumerable()
                                         where r.Field<string>("Item") == selectItem.ToString()
                                         where r.Field<string>("Type") == selectType.ToString()
                                         select r["ProductName"]).Distinct().ToList();
                if (productNameOption.Count > 0)
                {
                    foreach (string item in productNameOption)
                    {
                        productNameValue.Items.Add(item);
                    }
                    productNameValue.SelectedIndex = 0;

                    if (productNameValue.Items.Count > 0)
                    {
                        var productName = productNameValue.Items[0].ToString();


                        var selectProductCode = (from r in dt.AsEnumerable()
                                                 where r.Field<string>("Item") == selectItem.ToString()
                                                 where r.Field<string>("Type") == selectType.ToString()
                                                 where r.Field<string>("ProductName") == productName
                                                 select r["Code"]).Distinct().ToList();
                        if (selectProductCode.Count > 0)
                        {
                            productCodeValue.Text = selectProductCode[0].ToString();
                            productCodeValue.ReadOnly = true;
                        }
                    }
                }
            }
        }

        private void productNameValue_TextChanged(object sender, EventArgs e)
        {
            if (!pageLoad)
            {
                var selectItem = itemValue.Text;
                var selectType = typeValue.Text;
                var selectProductName = productNameValue.Text;

                productCodeValue.Text = "";
                var selectProductCode = (from r in dt.AsEnumerable()
                                         where r.Field<string>("Item") == selectItem.ToString()
                                         where r.Field<string>("Type") == selectType.ToString()
                                         where r.Field<string>("ProductName") == selectProductName.ToString()
                                         select r["Code"]).Distinct().ToList();
                if (selectProductCode.Count > 0)
                {
                    productCodeValue.Text = selectProductCode[0].ToString();
                    productCodeValue.ReadOnly = true;
                }
            }
        }

        private void quantityValue_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnAddUpdate_Click(object sender, EventArgs e)
        {
            if (dateValue.Text == string.Empty)
            {
                MessageBox.Show("Please enter date of entry ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (quantityValue.Text == string.Empty)
            {
                MessageBox.Show("Please enter qunatity ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (purchaseNoValue.Text == string.Empty)
            {
                MessageBox.Show("Please enter purchase no ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {   if (!Login.isManager)
                {
                    con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Admin\Downloads\InventoryApplication\InventoryApplication\Database.mdf;Integrated Security=True");
                    con.Open();

                    cmd = new SqlCommand("select * from Item_List where Code='" + productCodeValue.Text.Trim() + "'", con);
                    dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Admin\Downloads\InventoryApplication\InventoryApplication\Database.mdf;Integrated Security=True");
                        con.Open();

                        SqlTransaction transaction = con.BeginTransaction();

                        float removeQuantity = float.Parse(quantityValue.Text);
                        SqlCommand cmd0 = new SqlCommand("insert into Billing_List values(@Date, @CreateBy, @ProductCode, @Quantity, @BillNo)", con, transaction);
                        cmd0.Parameters.AddWithValue("Date", dateValue.Text.Trim());
                        cmd0.Parameters.AddWithValue("CreateBy", Login.loginUser);
                        cmd0.Parameters.AddWithValue("ProductCode", productCodeValue.Text.Trim());
                        cmd0.Parameters.AddWithValue("Quantity", removeQuantity);
                        cmd0.Parameters.AddWithValue("BillNo", purchaseNoValue.Text.Trim());
                        cmd0.Transaction = transaction;
                        cmd0.ExecuteNonQuery();

                        SqlCommand cmd1 = new SqlCommand("select quantity from Item_List where Code = '" + productCodeValue.Text + "'", con, transaction);
                        SqlDataReader dr1 = cmd1.ExecuteReader();
                        float existsQuantity = 0;
                        while (dr1.Read())
                        {
                            existsQuantity = float.Parse(dr1[0].ToString());
                        }
                        float checkValue = existsQuantity - removeQuantity;

                        if (checkValue < 0)
                        {
                            MessageBox.Show("Updating billing item is less than inventory stock.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            transaction.Rollback();
                            return;
                        }

                        cmd1.Dispose();
                        dr1.Dispose();

                        SqlCommand cmd2 = new SqlCommand("Update Item_List set Quantity = '" + checkValue + "' where Code = '" + productCodeValue.Text + "'", con, transaction);
                        cmd2.Transaction = transaction;
                        cmd2.ExecuteNonQuery();
                        cmd2.Dispose();

                        transaction.Commit();
                        MessageBox.Show("Billing successfully done.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        this.Hide();
                        AddUpdateForm addUpdateForm = new AddUpdateForm();
                        addUpdateForm.ShowDialog();
                    }
                    else
                    {
                        dr.Close();
                        MessageBox.Show("Scanned code is Not exist ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else if (InventoryList.isFormAdd)
                {
                    if (itemValue.Text == string.Empty)
                    {
                        MessageBox.Show("Please select item ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (typeValue.Text == string.Empty)
                    {
                        MessageBox.Show("Please enter type ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (productNameValue.Text == string.Empty)
                    {
                        MessageBox.Show("Please enter product ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        cmd = new SqlCommand("select * from Inventory_List where PurchaseNo='" + purchaseNoValue.Text + "'", con);
                        dr = cmd.ExecuteReader();
                        if (dr.Read())
                        {
                            dr.Close();
                            MessageBox.Show("Purchase No Already exist ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Admin\Downloads\InventoryApplication\InventoryApplication\Database.mdf;Integrated Security=True");
                            con.Open();
                            SqlTransaction transaction = con.BeginTransaction();
                            try
                            {
                                float AddedQuantity = float.Parse(quantityValue.Text);
                                SqlCommand cmd0 = new SqlCommand("insert into Inventory_List values(@Date, @CreateManager, @Item, @Type, @ProductName, @ProductCode, @Quantity, @UpdateManager, @PurchaseNo)", con, transaction);
                                cmd0.Parameters.AddWithValue("Date", dateValue.Text.Trim());
                                cmd0.Parameters.AddWithValue("CreateManager", Login.loginUser);
                                cmd0.Parameters.AddWithValue("Item", itemValue.Text);
                                cmd0.Parameters.AddWithValue("Type", typeValue.Text);
                                cmd0.Parameters.AddWithValue("ProductName", productNameValue.Text);
                                cmd0.Parameters.AddWithValue("ProductCode", productCodeValue.Text);
                                cmd0.Parameters.AddWithValue("Quantity", AddedQuantity);
                                cmd0.Parameters.AddWithValue("UpdateManager", "");
                                cmd0.Parameters.AddWithValue("PurchaseNo", purchaseNoValue.Text.Trim());
                                cmd0.Transaction = transaction;
                                cmd0.ExecuteNonQuery();

                                SqlCommand cmd1 = new SqlCommand("select quantity from Item_List where Code = '" + productCodeValue.Text + "'", con, transaction);
                                SqlDataReader dr1 = cmd1.ExecuteReader();
                                float existsQuantity = 0;
                                while (dr1.Read())
                                {
                                    existsQuantity = float.Parse(dr1[0].ToString());
                                }
                                float totalQuantity = existsQuantity + AddedQuantity;
                                cmd1.Dispose();
                                dr1.Dispose();

                                SqlCommand cmd2 = new SqlCommand("Update Item_List set Quantity = '" + totalQuantity + "' where Code = '" + productCodeValue.Text + "'", con, transaction);
                                cmd2.Transaction = transaction;
                                cmd2.ExecuteNonQuery();
                                cmd2.Dispose();

                                transaction.Commit();
                                MessageBox.Show("Purchase has added successfully.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
                }
                else
                {
                    con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Admin\Downloads\InventoryApplication\InventoryApplication\Database.mdf;Integrated Security=True");
                    con.Open();
                    SqlTransaction transaction = con.BeginTransaction();
                    try
                    {
                        float AddedQuantity = float.Parse(quantityValue.Text);
                        SqlCommand cmd0 = new SqlCommand("select Quantity from Inventory_List where PurchaseNo = '" + purchaseNoValue.Text + "'", con, transaction);
                        SqlDataReader dr0 = cmd0.ExecuteReader();
                        float existsQuantity = 0;
                        while (dr0.Read())
                        {
                            existsQuantity = float.Parse(dr0[0].ToString());
                        }
                        cmd0.Dispose();
                        dr0.Dispose();

                        SqlCommand cmd1 = new SqlCommand("select Quantity from Item_List where Code = '" + productCodeValue.Text + "'", con, transaction);
                        SqlDataReader dr1 = cmd1.ExecuteReader();
                        float existsItemQuantity = 0;
                        while (dr1.Read())
                        {
                            existsItemQuantity = float.Parse(dr1[0].ToString());
                        }
                        cmd1.Dispose();
                        dr1.Dispose();

                        float updateValue = existsQuantity - float.Parse(quantityValue.Text);
                        float checkValue = (existsItemQuantity - updateValue);

                        if(checkValue < 0)
                        {
                            MessageBox.Show("Updating purchase item is less than inventory stock.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            transaction.Rollback();
                            return;
                        }

                        SqlCommand cmd2 = new SqlCommand("Update Inventory_List set Date = '" + dateValue.Text + "', Quantity = '" + float.Parse(quantityValue.Text) + "', UpdateManager = '" + Login.loginUser + "' where PurchaseNo = '" + purchaseNoValue.Text + "'", con, transaction);
                        cmd2.Transaction = transaction;
                        cmd2.ExecuteNonQuery();
                        cmd2.Dispose();

                        SqlCommand cmd3 = new SqlCommand("Update Item_List set Quantity = '" + checkValue + "' where Code = '" + productCodeValue.Text + "'", con, transaction);
                        cmd3.Transaction = transaction;
                        cmd3.ExecuteNonQuery();
                        cmd3.Dispose();

                        transaction.Commit();
                        MessageBox.Show("Purchase has updated successfully.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
        }

        private void BtnViewInventory_Click(object sender, EventArgs e)
        {
            if (!Login.isManager)
            {
                this.Hide();
                BillingList billingList = new BillingList();
                billingList.ShowDialog();
            }
            else
            {
                this.Hide();
                InventoryList inventoryList = new InventoryList();
                inventoryList.ShowDialog();
            }
        }

        private void itemValue_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void productNameValue_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void purchaseNoValue_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateValue_ValueChanged(object sender, EventArgs e)
        {

        }

        private void labelTitle_Click(object sender, EventArgs e)
        {

        }
    }
}