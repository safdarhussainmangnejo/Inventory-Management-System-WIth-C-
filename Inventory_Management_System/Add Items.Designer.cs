namespace Inventory_Management_System
{
    partial class Add_Items
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
            this.textBoxItemId = new System.Windows.Forms.TextBox();
            this.textBoxItemName = new System.Windows.Forms.TextBox();
            this.textBoxCompany = new System.Windows.Forms.TextBox();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.textBoxQuantity = new System.Windows.Forms.TextBox();
            this.buttonItemAdd = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxItemId
            // 
            this.textBoxItemId.Location = new System.Drawing.Point(63, 24);
            this.textBoxItemId.Name = "textBoxItemId";
            this.textBoxItemId.Size = new System.Drawing.Size(318, 20);
            this.textBoxItemId.TabIndex = 1;
            this.textBoxItemId.Text = "Item ID";
            // 
            // textBoxItemName
            // 
            this.textBoxItemName.Location = new System.Drawing.Point(63, 63);
            this.textBoxItemName.Name = "textBoxItemName";
            this.textBoxItemName.Size = new System.Drawing.Size(318, 20);
            this.textBoxItemName.TabIndex = 2;
            this.textBoxItemName.Text = "Item Name";
            // 
            // textBoxCompany
            // 
            this.textBoxCompany.Location = new System.Drawing.Point(63, 103);
            this.textBoxCompany.Name = "textBoxCompany";
            this.textBoxCompany.Size = new System.Drawing.Size(318, 20);
            this.textBoxCompany.TabIndex = 3;
            this.textBoxCompany.Text = "Company Name";
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Location = new System.Drawing.Point(63, 152);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(318, 20);
            this.textBoxPrice.TabIndex = 4;
            this.textBoxPrice.Text = "Price (per item)";
            // 
            // textBoxQuantity
            // 
            this.textBoxQuantity.Location = new System.Drawing.Point(63, 203);
            this.textBoxQuantity.Name = "textBoxQuantity";
            this.textBoxQuantity.Size = new System.Drawing.Size(318, 20);
            this.textBoxQuantity.TabIndex = 5;
            this.textBoxQuantity.Text = "Total Quantity";
            // 
            // buttonItemAdd
            // 
            this.buttonItemAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonItemAdd.Location = new System.Drawing.Point(63, 247);
            this.buttonItemAdd.Name = "buttonItemAdd";
            this.buttonItemAdd.Size = new System.Drawing.Size(104, 32);
            this.buttonItemAdd.TabIndex = 6;
            this.buttonItemAdd.Text = "Add Item";
            this.buttonItemAdd.UseVisualStyleBackColor = true;
            this.buttonItemAdd.Click += new System.EventHandler(this.buttonItemAdd_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClose.Location = new System.Drawing.Point(277, 247);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(104, 32);
            this.buttonClose.TabIndex = 6;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(5, 305);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(423, 162);
            this.dataGridView1.TabIndex = 7;
            // 
            // Add_Items
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 479);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonItemAdd);
            this.Controls.Add(this.textBoxQuantity);
            this.Controls.Add(this.textBoxPrice);
            this.Controls.Add(this.textBoxCompany);
            this.Controls.Add(this.textBoxItemName);
            this.Controls.Add(this.textBoxItemId);
            this.Name = "Add_Items";
            this.Text = "Add_Items";
            this.Load += new System.EventHandler(this.Add_Items_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxItemId;
        private System.Windows.Forms.TextBox textBoxItemName;
        private System.Windows.Forms.TextBox textBoxCompany;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.TextBox textBoxQuantity;
        private System.Windows.Forms.Button buttonItemAdd;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}