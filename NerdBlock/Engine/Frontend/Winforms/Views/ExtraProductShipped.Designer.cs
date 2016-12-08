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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvAddExtra = new NerdBlock.Engine.Frontend.Winforms.Implementation.DataGridDisplayView();
            this.btnAddProductToOverStock = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.iName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExtraProduct)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAddExtra)).BeginInit();
            this.groupBox2.SuspendLayout();
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
            this.iName,
            this.iQuantity,
            this.iDescription});
            this.dgvExtraProduct.Location = new System.Drawing.Point(18, 50);
            this.dgvExtraProduct.Name = "dgvExtraProduct";
            this.dgvExtraProduct.ReadOnly = true;
            this.dgvExtraProduct.RowHeadersVisible = false;
            this.dgvExtraProduct.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvExtraProduct.Size = new System.Drawing.Size(471, 168);
            this.dgvExtraProduct.TabIndex = 68;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvAddExtra);
            this.groupBox1.Controls.Add(this.btnAddProductToOverStock);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(18, 224);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(471, 128);
            this.groupBox1.TabIndex = 69;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add Extra Product";
            // 
            // dgvAddExtra
            // 
            this.dgvAddExtra.AllowUserToAddRows = false;
            this.dgvAddExtra.AllowUserToDeleteRows = false;
            this.dgvAddExtra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAddExtra.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pName,
            this.pQuantity,
            this.pDescription});
            this.dgvAddExtra.Location = new System.Drawing.Point(6, 19);
            this.dgvAddExtra.Name = "dgvAddExtra";
            this.dgvAddExtra.ReadOnly = true;
            this.dgvAddExtra.RowHeadersVisible = false;
            this.dgvAddExtra.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAddExtra.Size = new System.Drawing.Size(264, 99);
            this.dgvAddExtra.TabIndex = 70;
            // 
            // btnAddProductToOverStock
            // 
            this.btnAddProductToOverStock.Location = new System.Drawing.Point(276, 76);
            this.btnAddProductToOverStock.Name = "btnAddProductToOverStock";
            this.btnAddProductToOverStock.Size = new System.Drawing.Size(189, 42);
            this.btnAddProductToOverStock.TabIndex = 8;
            this.btnAddProductToOverStock.Text = "Add Product to Overstock\r\n";
            this.btnAddProductToOverStock.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtProductName);
            this.groupBox2.Location = new System.Drawing.Point(276, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(189, 51);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Search Products";
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(6, 19);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(177, 20);
            this.txtProductName.TabIndex = 3;
            // 
            // iName
            // 
            this.iName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.iName.DataPropertyName = "Name";
            this.iName.FillWeight = 40F;
            this.iName.HeaderText = "Name";
            this.iName.Name = "iName";
            this.iName.ReadOnly = true;
            // 
            // iQuantity
            // 
            this.iQuantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.iQuantity.DataPropertyName = "Quantity";
            this.iQuantity.FillWeight = 30F;
            this.iQuantity.HeaderText = "Quantity";
            this.iQuantity.Name = "iQuantity";
            this.iQuantity.ReadOnly = true;
            // 
            // iDescription
            // 
            this.iDescription.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.iDescription.DataPropertyName = "Description";
            this.iDescription.FillWeight = 30F;
            this.iDescription.HeaderText = "Description";
            this.iDescription.Name = "iDescription";
            this.iDescription.ReadOnly = true;
            // 
            // pName
            // 
            this.pName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.pName.DataPropertyName = "Name";
            this.pName.FillWeight = 40F;
            this.pName.HeaderText = "Name";
            this.pName.Name = "pName";
            this.pName.ReadOnly = true;
            // 
            // pQuantity
            // 
            this.pQuantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.pQuantity.DataPropertyName = "Quantity";
            this.pQuantity.FillWeight = 30F;
            this.pQuantity.HeaderText = "Quantity";
            this.pQuantity.Name = "pQuantity";
            this.pQuantity.ReadOnly = true;
            // 
            // pDescription
            // 
            this.pDescription.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.pDescription.DataPropertyName = "Description";
            this.pDescription.FillWeight = 30F;
            this.pDescription.HeaderText = "Description";
            this.pDescription.Name = "pDescription";
            this.pDescription.ReadOnly = true;
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvAddExtra)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label5;
        private Implementation.DataGridDisplayView dgvExtraProduct;
        private System.Windows.Forms.GroupBox groupBox1;
        private Implementation.DataGridDisplayView dgvAddExtra;
        private System.Windows.Forms.Button btnAddProductToOverStock;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn iName;
        private System.Windows.Forms.DataGridViewTextBoxColumn iQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn pName;
        private System.Windows.Forms.DataGridViewTextBoxColumn pQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn pDescription;
    }
}
