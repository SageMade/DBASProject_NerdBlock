namespace NerdBlock.Engine.Frontend.Winforms.Views
{
    partial class AddOrder
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
            this.lblQuantityOrdered = new System.Windows.Forms.Label();
            this.txtQuantityOrdered = new System.Windows.Forms.TextBox();
            this.btnAddOrder = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cbSupplierID = new System.Windows.Forms.ComboBox();
            this.btnAddSupplier = new System.Windows.Forms.Button();
            this.lblSupplier = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtDepth = new System.Windows.Forms.TextBox();
            this.txtHeight = new System.Windows.Forms.TextBox();
            this.txtWidth = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.grpAdd = new System.Windows.Forms.GroupBox();
            this.lblBatchCost = new System.Windows.Forms.Label();
            this.txtBatchCost = new System.Windows.Forms.TextBox();
            this.dgvOrder = new NerdBlock.Engine.Frontend.Winforms.Implementation.DataGridDisplayView();
            this.ProdName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpAdd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrder)).BeginInit();
            this.SuspendLayout();
            // 
            // lblQuantityOrdered
            // 
            this.lblQuantityOrdered.AutoSize = true;
            this.lblQuantityOrdered.Location = new System.Drawing.Point(221, 29);
            this.lblQuantityOrdered.Name = "lblQuantityOrdered";
            this.lblQuantityOrdered.Size = new System.Drawing.Size(87, 13);
            this.lblQuantityOrdered.TabIndex = 2;
            this.lblQuantityOrdered.Text = "Quantity Ordered";
            // 
            // txtQuantityOrdered
            // 
            this.txtQuantityOrdered.Location = new System.Drawing.Point(310, 26);
            this.txtQuantityOrdered.Name = "txtQuantityOrdered";
            this.txtQuantityOrdered.Size = new System.Drawing.Size(84, 20);
            this.txtQuantityOrdered.TabIndex = 5;
            // 
            // btnAddOrder
            // 
            this.btnAddOrder.Location = new System.Drawing.Point(321, 422);
            this.btnAddOrder.Name = "btnAddOrder";
            this.btnAddOrder.Size = new System.Drawing.Size(99, 24);
            this.btnAddOrder.TabIndex = 20;
            this.btnAddOrder.Text = "Add Order";
            this.btnAddOrder.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 7);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 20);
            this.label2.TabIndex = 25;
            this.label2.Text = "Add New Order";
            // 
            // cbSupplierID
            // 
            this.cbSupplierID.FormattingEnabled = true;
            this.cbSupplierID.Location = new System.Drawing.Point(157, 38);
            this.cbSupplierID.Margin = new System.Windows.Forms.Padding(2);
            this.cbSupplierID.Name = "cbSupplierID";
            this.cbSupplierID.Size = new System.Drawing.Size(156, 21);
            this.cbSupplierID.TabIndex = 31;
            // 
            // btnAddSupplier
            // 
            this.btnAddSupplier.Location = new System.Drawing.Point(329, 36);
            this.btnAddSupplier.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddSupplier.Name = "btnAddSupplier";
            this.btnAddSupplier.Size = new System.Drawing.Size(91, 22);
            this.btnAddSupplier.TabIndex = 30;
            this.btnAddSupplier.Text = "Add Supplier";
            this.btnAddSupplier.UseVisualStyleBackColor = true;
            // 
            // lblSupplier
            // 
            this.lblSupplier.AutoSize = true;
            this.lblSupplier.Location = new System.Drawing.Point(107, 41);
            this.lblSupplier.Name = "lblSupplier";
            this.lblSupplier.Size = new System.Drawing.Size(45, 13);
            this.lblSupplier.TabIndex = 28;
            this.lblSupplier.Text = "Supplier";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(99, 123);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(183, 49);
            this.txtDescription.TabIndex = 4;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(312, 123);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(92, 28);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // txtDepth
            // 
            this.txtDepth.Location = new System.Drawing.Point(99, 98);
            this.txtDepth.Margin = new System.Windows.Forms.Padding(2);
            this.txtDepth.Name = "txtDepth";
            this.txtDepth.Size = new System.Drawing.Size(84, 20);
            this.txtDepth.TabIndex = 3;
            // 
            // txtHeight
            // 
            this.txtHeight.Location = new System.Drawing.Point(99, 75);
            this.txtHeight.Margin = new System.Windows.Forms.Padding(2);
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.Size = new System.Drawing.Size(84, 20);
            this.txtHeight.TabIndex = 2;
            // 
            // txtWidth
            // 
            this.txtWidth.Location = new System.Drawing.Point(99, 51);
            this.txtWidth.Margin = new System.Windows.Forms.Padding(2);
            this.txtWidth.Name = "txtWidth";
            this.txtWidth.Size = new System.Drawing.Size(84, 20);
            this.txtWidth.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(33, 126);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 13);
            this.label10.TabIndex = 60;
            this.label10.Text = "Description";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(59, 101);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(36, 13);
            this.label9.TabIndex = 59;
            this.label9.Text = "Depth";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(58, 78);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 58;
            this.label7.Text = "Height";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(61, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 57;
            this.label5.Text = "Width";
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(99, 26);
            this.txtProductName.Margin = new System.Windows.Forms.Padding(2);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(84, 20);
            this.txtProductName.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 265);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 55;
            this.label4.Text = "Product Name";
            // 
            // grpAdd
            // 
            this.grpAdd.Controls.Add(this.txtDepth);
            this.grpAdd.Controls.Add(this.txtHeight);
            this.grpAdd.Controls.Add(this.lblBatchCost);
            this.grpAdd.Controls.Add(this.txtWidth);
            this.grpAdd.Controls.Add(this.txtBatchCost);
            this.grpAdd.Controls.Add(this.txtProductName);
            this.grpAdd.Controls.Add(this.lblQuantityOrdered);
            this.grpAdd.Controls.Add(this.txtQuantityOrdered);
            this.grpAdd.Controls.Add(this.txtDescription);
            this.grpAdd.Controls.Add(this.label9);
            this.grpAdd.Controls.Add(this.label7);
            this.grpAdd.Controls.Add(this.btnAdd);
            this.grpAdd.Controls.Add(this.label5);
            this.grpAdd.Controls.Add(this.label10);
            this.grpAdd.Location = new System.Drawing.Point(11, 238);
            this.grpAdd.Name = "grpAdd";
            this.grpAdd.Size = new System.Drawing.Size(409, 178);
            this.grpAdd.TabIndex = 66;
            this.grpAdd.TabStop = false;
            this.grpAdd.Text = "Add Product";
            // 
            // lblBatchCost
            // 
            this.lblBatchCost.AutoSize = true;
            this.lblBatchCost.Location = new System.Drawing.Point(245, 54);
            this.lblBatchCost.Name = "lblBatchCost";
            this.lblBatchCost.Size = new System.Drawing.Size(59, 13);
            this.lblBatchCost.TabIndex = 66;
            this.lblBatchCost.Text = "Batch Cost";
            // 
            // txtBatchCost
            // 
            this.txtBatchCost.Location = new System.Drawing.Point(310, 51);
            this.txtBatchCost.Name = "txtBatchCost";
            this.txtBatchCost.Size = new System.Drawing.Size(84, 20);
            this.txtBatchCost.TabIndex = 6;
            // 
            // dgvOrder
            // 
            this.dgvOrder.AllowUserToAddRows = false;
            this.dgvOrder.AllowUserToDeleteRows = false;
            this.dgvOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrder.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProdName,
            this.Quantity,
            this.Price});
            this.dgvOrder.Location = new System.Drawing.Point(11, 64);
            this.dgvOrder.Name = "dgvOrder";
            this.dgvOrder.ReadOnly = true;
            this.dgvOrder.RowHeadersVisible = false;
            this.dgvOrder.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOrder.Size = new System.Drawing.Size(409, 168);
            this.dgvOrder.TabIndex = 67;
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
            // AddOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvOrder);
            this.Controls.Add(this.cbSupplierID);
            this.Controls.Add(this.btnAddSupplier);
            this.Controls.Add(this.lblSupplier);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAddOrder);
            this.Controls.Add(this.grpAdd);
            this.Name = "AddOrder";
            this.Size = new System.Drawing.Size(442, 454);
            this.grpAdd.ResumeLayout(false);
            this.grpAdd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrder)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblQuantityOrdered;
        private System.Windows.Forms.TextBox txtQuantityOrdered;
        private System.Windows.Forms.Button btnAddOrder;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblSupplier;
        private System.Windows.Forms.ComboBox cbSupplierID;
        private System.Windows.Forms.Button btnAddSupplier;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtDepth;
        private System.Windows.Forms.TextBox txtHeight;
        private System.Windows.Forms.TextBox txtWidth;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox grpAdd;
        private System.Windows.Forms.Label lblBatchCost;
        private System.Windows.Forms.TextBox txtBatchCost;
        private Implementation.DataGridDisplayView dgvOrder;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProdName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
    }
}
