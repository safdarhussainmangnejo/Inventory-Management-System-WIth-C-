namespace Inventory_Management_System
{
    partial class UpdateForm
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
            this.buttonItemAdd = new System.Windows.Forms.Button();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxCom = new System.Windows.Forms.TextBox();
            this.textBoxPric = new System.Windows.Forms.TextBox();
            this.textBoxQuan = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonClear = new System.Windows.Forms.Button();
            this.dataGridViewProducts = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonItemAdd
            // 
            this.buttonItemAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonItemAdd.Location = new System.Drawing.Point(110, 258);
            this.buttonItemAdd.Name = "buttonItemAdd";
            this.buttonItemAdd.Size = new System.Drawing.Size(104, 32);
            this.buttonItemAdd.TabIndex = 7;
            this.buttonItemAdd.Text = "Update Item";
            this.buttonItemAdd.UseVisualStyleBackColor = true;
            this.buttonItemAdd.Click += new System.EventHandler(this.buttonItemAdd_Click);
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(110, 39);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(293, 20);
            this.textBoxID.TabIndex = 8;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(110, 89);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(293, 20);
            this.textBoxName.TabIndex = 8;
            // 
            // textBoxCom
            // 
            this.textBoxCom.Location = new System.Drawing.Point(110, 135);
            this.textBoxCom.Name = "textBoxCom";
            this.textBoxCom.Size = new System.Drawing.Size(293, 20);
            this.textBoxCom.TabIndex = 8;
            // 
            // textBoxPric
            // 
            this.textBoxPric.Location = new System.Drawing.Point(110, 179);
            this.textBoxPric.Name = "textBoxPric";
            this.textBoxPric.Size = new System.Drawing.Size(293, 20);
            this.textBoxPric.TabIndex = 8;
            // 
            // textBoxQuan
            // 
            this.textBoxQuan.Location = new System.Drawing.Point(110, 223);
            this.textBoxQuan.Name = "textBoxQuan";
            this.textBoxQuan.Size = new System.Drawing.Size(293, 20);
            this.textBoxQuan.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Item ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Item Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Item Company:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Item Price:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 223);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Item Quantity:";
            // 
            // buttonClear
            // 
            this.buttonClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClear.Location = new System.Drawing.Point(299, 258);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(104, 32);
            this.buttonClear.TabIndex = 7;
            this.buttonClear.Text = "Close";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // dataGridViewProducts
            // 
            this.dataGridViewProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProducts.Location = new System.Drawing.Point(2, 296);
            this.dataGridViewProducts.Name = "dataGridViewProducts";
            this.dataGridViewProducts.Size = new System.Drawing.Size(425, 181);
            this.dataGridViewProducts.TabIndex = 10;
            this.dataGridViewProducts.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewProducts_RowHeaderMouseClick);
            // 
            // UpdateForm
            // 
            this.ClientSize = new System.Drawing.Size(430, 479);
            this.Controls.Add(this.dataGridViewProducts);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxQuan);
            this.Controls.Add(this.textBoxPric);
            this.Controls.Add(this.textBoxCom);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonItemAdd);
            this.Name = "UpdateForm";
            this.Text = "Update Item";
            this.Load += new System.EventHandler(this.UpdateForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProducts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button buttonItemUpdate;
        private System.Windows.Forms.TextBox textBoxQuantity;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.TextBox textBoxCompany;
        private System.Windows.Forms.TextBox textBoxItemName;
        private System.Windows.Forms.TextBox textBoxItemId;
        private System.Windows.Forms.Button buttonItemAdd;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxCom;
        private System.Windows.Forms.TextBox textBoxPric;
        private System.Windows.Forms.TextBox textBoxQuan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.DataGridView dataGridViewProducts;
    }
}