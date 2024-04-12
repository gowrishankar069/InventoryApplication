namespace RegistrationAndLogin
{
    partial class StockList
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelTitle = new System.Windows.Forms.Label();
            this.dataGridStockView1 = new System.Windows.Forms.DataGridView();
            this.btnViewInventory = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridStockView1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(650, 29);
            this.labelTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(86, 23);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Stock List";
            // 
            // dataGridStockView1
            // 
            this.dataGridStockView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridStockView1.Location = new System.Drawing.Point(412, 105);
            this.dataGridStockView1.Margin = new System.Windows.Forms.Padding(1);
            this.dataGridStockView1.Name = "dataGridStockView1";
            this.dataGridStockView1.RowTemplate.Height = 35;
            this.dataGridStockView1.Size = new System.Drawing.Size(570, 526);
            this.dataGridStockView1.TabIndex = 0;
            this.dataGridStockView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridStockView1_CellContentClick);
            // 
            // btnViewInventory
            // 
            this.btnViewInventory.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewInventory.Location = new System.Drawing.Point(1042, 29);
            this.btnViewInventory.Margin = new System.Windows.Forms.Padding(2);
            this.btnViewInventory.Name = "btnViewInventory";
            this.btnViewInventory.Size = new System.Drawing.Size(214, 32);
            this.btnViewInventory.TabIndex = 13;
            this.btnViewInventory.Text = "View Inventory";
            this.btnViewInventory.UseVisualStyleBackColor = true;
            this.btnViewInventory.Click += new System.EventHandler(this.btnViewInventory_Click);
            // 
            // StockList
            // 
            this.ClientSize = new System.Drawing.Size(1334, 708);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.dataGridStockView1);
            this.Controls.Add(this.btnViewInventory);
            this.Name = "StockList";
            this.Load += new System.EventHandler(this.StockList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridStockView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.DataGridView dataGridStockView1;
        private System.Windows.Forms.Button btnViewInventory;
    }
}