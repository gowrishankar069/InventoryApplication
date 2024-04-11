namespace InventoryApplication
{
    partial class BillingList
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
            this.dataGridBillView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridBillView1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(650, 29);
            this.labelTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(89, 23);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Billing List";
            // 
            // dataGridBillView1
            // 
            this.dataGridBillView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridBillView1.Location = new System.Drawing.Point(412, 105);
            this.dataGridBillView1.Margin = new System.Windows.Forms.Padding(1);
            this.dataGridBillView1.Name = "dataGridBillView1";
            this.dataGridBillView1.RowTemplate.Height = 35;
            this.dataGridBillView1.Size = new System.Drawing.Size(546, 374);
            this.dataGridBillView1.TabIndex = 0;
            this.dataGridBillView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridBillView1_CellContentClick);
            // 
            // BillingList
            // 
            this.ClientSize = new System.Drawing.Size(1334, 708);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.dataGridBillView1);
            this.Name = "BillingList";
            this.Load += new System.EventHandler(this.BillingList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridBillView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.DataGridView dataGridBillView1;
    }
}