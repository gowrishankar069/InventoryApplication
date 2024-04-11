using System.Windows.Forms.VisualStyles;

namespace InventoryApplication
{
    partial class AddUpdateForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Add Update Form

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelDate = new System.Windows.Forms.Label();
            this.labelPurchaseNo = new System.Windows.Forms.Label();
            this.labelItem = new System.Windows.Forms.Label();
            this.labelType = new System.Windows.Forms.Label();
            this.labelProductName = new System.Windows.Forms.Label();
            this.labelProductCode = new System.Windows.Forms.Label();
            this.labelQuantity = new System.Windows.Forms.Label();
            this.dateValue = new System.Windows.Forms.DateTimePicker();
            this.purchaseNoValue = new System.Windows.Forms.TextBox();
            this.itemValue = new System.Windows.Forms.ComboBox();
            this.typeValue = new System.Windows.Forms.ComboBox();
            this.productNameValue = new System.Windows.Forms.ComboBox();
            this.productCodeValue = new System.Windows.Forms.TextBox();
            this.quantityValue = new System.Windows.Forms.NumericUpDown();
            this.btnAddUpdate = new System.Windows.Forms.Button();
            this.btnViewInventory = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.quantityValue)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(312, 9);
            this.labelTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(108, 23);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Add Purchase";
            this.labelTitle.Click += new System.EventHandler(this.labelTitle_Click);
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDate.Location = new System.Drawing.Point(169, 47);
            this.labelDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(45, 23);
            this.labelDate.TabIndex = 0;
            this.labelDate.Text = "Date";
            // 
            // labelPurchaseNo
            // 
            this.labelPurchaseNo.AutoSize = true;
            this.labelPurchaseNo.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPurchaseNo.Location = new System.Drawing.Point(169, 107);
            this.labelPurchaseNo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPurchaseNo.Name = "labelPurchaseNo";
            this.labelPurchaseNo.Size = new System.Drawing.Size(99, 23);
            this.labelPurchaseNo.TabIndex = 1;
            this.labelPurchaseNo.Text = "Purchase No";
            // 
            // labelItem
            // 
            this.labelItem.AutoSize = true;
            this.labelItem.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelItem.Location = new System.Drawing.Point(167, 169);
            this.labelItem.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelItem.Name = "labelItem";
            this.labelItem.Size = new System.Drawing.Size(45, 23);
            this.labelItem.TabIndex = 1;
            this.labelItem.Text = "Item";
            // 
            // labelType
            // 
            this.labelType.AutoSize = true;
            this.labelType.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelType.Location = new System.Drawing.Point(167, 221);
            this.labelType.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelType.Name = "labelType";
            this.labelType.Size = new System.Drawing.Size(47, 23);
            this.labelType.TabIndex = 2;
            this.labelType.Text = "Type";
            // 
            // labelProductName
            // 
            this.labelProductName.AutoSize = true;
            this.labelProductName.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProductName.Location = new System.Drawing.Point(167, 288);
            this.labelProductName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelProductName.Name = "labelProductName";
            this.labelProductName.Size = new System.Drawing.Size(111, 23);
            this.labelProductName.TabIndex = 3;
            this.labelProductName.Text = "Product Name";
            // 
            // labelProductCode
            // 
            this.labelProductCode.AutoSize = true;
            this.labelProductCode.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProductCode.Location = new System.Drawing.Point(169, 355);
            this.labelProductCode.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelProductCode.Name = "labelProductCode";
            this.labelProductCode.Size = new System.Drawing.Size(106, 23);
            this.labelProductCode.TabIndex = 4;
            this.labelProductCode.Text = "Product Code";
            // 
            // labelQuantity
            // 
            this.labelQuantity.AutoSize = true;
            this.labelQuantity.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuantity.Location = new System.Drawing.Point(169, 416);
            this.labelQuantity.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelQuantity.Name = "labelQuantity";
            this.labelQuantity.Size = new System.Drawing.Size(76, 23);
            this.labelQuantity.TabIndex = 5;
            this.labelQuantity.Text = "Quantity";
            // 
            // dateValue
            // 
            this.dateValue.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateValue.Location = new System.Drawing.Point(360, 47);
            this.dateValue.Margin = new System.Windows.Forms.Padding(2);
            this.dateValue.Name = "dateValue";
            this.dateValue.Size = new System.Drawing.Size(168, 30);
            this.dateValue.TabIndex = 6;
            this.dateValue.ValueChanged += new System.EventHandler(this.dateValue_ValueChanged);
            // 
            // purchaseNoValue
            // 
            this.purchaseNoValue.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.purchaseNoValue.Location = new System.Drawing.Point(360, 100);
            this.purchaseNoValue.Margin = new System.Windows.Forms.Padding(2);
            this.purchaseNoValue.Name = "purchaseNoValue";
            this.purchaseNoValue.Size = new System.Drawing.Size(168, 30);
            this.purchaseNoValue.TabIndex = 10;
            this.purchaseNoValue.TextChanged += new System.EventHandler(this.purchaseNoValue_TextChanged);
            // 
            // itemValue
            // 
            this.itemValue.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemValue.Location = new System.Drawing.Point(360, 166);
            this.itemValue.Margin = new System.Windows.Forms.Padding(2);
            this.itemValue.Name = "itemValue";
            this.itemValue.Size = new System.Drawing.Size(239, 31);
            this.itemValue.TabIndex = 7;
            this.itemValue.SelectedIndexChanged += new System.EventHandler(this.itemValue_SelectedIndexChanged);
            this.itemValue.TextChanged += new System.EventHandler(this.itemValue_TextChanged);
            // 
            // typeValue
            // 
            this.typeValue.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.typeValue.Location = new System.Drawing.Point(360, 221);
            this.typeValue.Margin = new System.Windows.Forms.Padding(2);
            this.typeValue.Name = "typeValue";
            this.typeValue.Size = new System.Drawing.Size(239, 31);
            this.typeValue.TabIndex = 8;
            this.typeValue.TextChanged += new System.EventHandler(this.typeValue_TextChanged);
            // 
            // productNameValue
            // 
            this.productNameValue.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productNameValue.Location = new System.Drawing.Point(360, 288);
            this.productNameValue.Margin = new System.Windows.Forms.Padding(2);
            this.productNameValue.Name = "productNameValue";
            this.productNameValue.Size = new System.Drawing.Size(239, 31);
            this.productNameValue.TabIndex = 9;
            this.productNameValue.SelectedIndexChanged += new System.EventHandler(this.productNameValue_SelectedIndexChanged);
            this.productNameValue.TextChanged += new System.EventHandler(this.productNameValue_TextChanged);
            // 
            // productCodeValue
            // 
            this.productCodeValue.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productCodeValue.Location = new System.Drawing.Point(360, 348);
            this.productCodeValue.Margin = new System.Windows.Forms.Padding(2);
            this.productCodeValue.Name = "productCodeValue";
            this.productCodeValue.Size = new System.Drawing.Size(168, 30);
            this.productCodeValue.TabIndex = 10;
            // 
            // quantityValue
            // 
            this.quantityValue.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantityValue.Location = new System.Drawing.Point(360, 414);
            this.quantityValue.Margin = new System.Windows.Forms.Padding(2);
            this.quantityValue.Name = "quantityValue";
            this.quantityValue.Size = new System.Drawing.Size(168, 30);
            this.quantityValue.TabIndex = 11;
            this.quantityValue.TextChanged += new System.EventHandler(this.quantityValue_TextChanged);
            // 
            // btnAddUpdate
            // 
            this.btnAddUpdate.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddUpdate.Location = new System.Drawing.Point(302, 458);
            this.btnAddUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddUpdate.Name = "btnAddUpdate";
            this.btnAddUpdate.Size = new System.Drawing.Size(135, 34);
            this.btnAddUpdate.TabIndex = 12;
            this.btnAddUpdate.Text = "Add";
            this.btnAddUpdate.UseVisualStyleBackColor = true;
            this.btnAddUpdate.Click += new System.EventHandler(this.BtnAddUpdate_Click);
            // 
            // btnViewInventory
            // 
            this.btnViewInventory.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewInventory.Location = new System.Drawing.Point(268, 505);
            this.btnViewInventory.Margin = new System.Windows.Forms.Padding(2);
            this.btnViewInventory.Name = "btnViewInventory";
            this.btnViewInventory.Size = new System.Drawing.Size(214, 32);
            this.btnViewInventory.TabIndex = 13;
            this.btnViewInventory.Text = "View Inventory";
            this.btnViewInventory.UseVisualStyleBackColor = true;
            this.btnViewInventory.Click += new System.EventHandler(this.BtnViewInventory_Click);
            // 
            // AddUpdateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 548);
            this.Controls.Add(this.btnViewInventory);
            this.Controls.Add(this.btnAddUpdate);
            this.Controls.Add(this.quantityValue);
            this.Controls.Add(this.productCodeValue);
            this.Controls.Add(this.productNameValue);
            this.Controls.Add(this.typeValue);
            this.Controls.Add(this.itemValue);
            this.Controls.Add(this.purchaseNoValue);
            this.Controls.Add(this.dateValue);
            this.Controls.Add(this.labelQuantity);
            this.Controls.Add(this.labelProductCode);
            this.Controls.Add(this.labelProductName);
            this.Controls.Add(this.labelType);
            this.Controls.Add(this.labelItem);
            this.Controls.Add(this.labelPurchaseNo);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.labelTitle);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimizeBox = false;
            this.Name = "AddUpdateForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Item";
            this.Load += new System.EventHandler(this.AddUpdateForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.quantityValue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Label labelPurchaseNo;
        private System.Windows.Forms.Label labelItem;
        private System.Windows.Forms.Label labelType;
        private System.Windows.Forms.Label labelProductName;
        private System.Windows.Forms.Label labelProductCode;
        private System.Windows.Forms.Label labelQuantity;
        private System.Windows.Forms.DateTimePicker dateValue;
        private System.Windows.Forms.TextBox purchaseNoValue;
        private System.Windows.Forms.ComboBox itemValue;
        private System.Windows.Forms.ComboBox typeValue;
        private System.Windows.Forms.ComboBox productNameValue;
        private System.Windows.Forms.TextBox productCodeValue;
        private System.Windows.Forms.NumericUpDown quantityValue;
        private System.Windows.Forms.Button btnAddUpdate;
        private System.Windows.Forms.Button btnViewInventory;
    }
}

