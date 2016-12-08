namespace NerdBlock.Engine.Frontend.Winforms.Views
{
    partial class ExtraProductShipped
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label5 = new System.Windows.Forms.Label();
            this.dgvExtraProduct = new NerdBlock.Engine.Frontend.Winforms.Implementation.DataGridDisplayView();
            this.ProdName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblQuantityOrdered = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExtraProduct)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(14, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(191, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Brick and Mortar Shipping";
            // 
            // dgvExtraProduct
            // 
            this.dgvExtraProduct.AllowUserToAddRows = false;
            this.dgvExtraProduct.AllowUserToDeleteRows = false;
            this.dgvExtraProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvExtraProduct.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProdName,
            this.Quantity,
            this.Price});
            this.dgvExtraProduct.Location = new System.Drawing.Point(18, 67);
            this.dgvExtraProduct.Name = "dgvExtraProduct";
            this.dgvExtraProduct.ReadOnly = true;
            this.dgvExtraProduct.RowHeadersVisible = false;
            this.dgvExtraProduct.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvExtraProduct.Size = new System.Drawing.Size(471, 168);
            this.dgvExtraProduct.TabIndex = 68;
            // 
            // ProdName
            // 
            this.ProdName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ProdName.DataPropertyName = "Name";
            this.ProdName.FillWeight = 40F;
            this.ProdName.HeaderText = "Name";
            this.ProdName.Name = "ProdName";
            this.ProdName.ReadOnly = true;
            // 
            // Quantity
            // 
            this.Quantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Quantity.DataPropertyName = "Quantity";
            this.Quantity.FillWeight = 30F;
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
            // 
            // Price
            // 
            this.Price.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Price.DataPropertyName = "Price";
            this.Price.FillWeight = 30F;
            this.Price.HeaderText = "Price";
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtPrice);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lblQuantityOrdered);
            this.groupBox1.Controls.Add(this.txtQuantity);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtProductName);
            this.groupBox1.Location = new System.Drawing.Point(18, 254);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(375, 103);
            this.groupBox1.TabIndex = 69;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add Extra Product";
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(93, 31);
            this.txtProductName.Margin = new System.Windows.Forms.Padding(2);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(84, 20);
            this.txtProductName.TabIndex = 61;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 70;
            this.label4.Text = "Product Name";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(241, 56);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 28);
            this.btnAdd.TabIndex = 71;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // lblQuantityOrdered
            // 
            this.lblQuantityOrdered.AutoSize = true;
            this.lblQuantityOrdered.Location = new System.Drawing.Point(44, 59);
            this.lblQuantityOrdered.Name = "lblQuantityOrdered";
            this.lblQuantityOrdered.Size = new System.Drawing.Size(46, 13);
            this.lblQuantityOrdered.TabIndex = 72;
            this.lblQuantityOrdered.Text = "Quantity";
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(93, 56);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(84, 20);
            this.txtQuantity.TabIndex = 73;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(204, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 74;
            this.label1.Text = "Price";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(241, 31);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(100, 20);
            this.txtPrice.TabIndex = 75;
            // 
            // ExtraProductShipped
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvExtraProduct);
            this.Controls.Add(this.label5);
            this.Name = "ExtraProductShipped";
            this.Size = new System.Drawing.Size(509, 368);
            ((System.ComponentModel.ISupportInitialize)(this.dgvExtraProduct)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label5;
        private Implementation.DataGridDisplayView dgvExtraProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProdName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblQuantityOrdered;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label label1;
    }
}
