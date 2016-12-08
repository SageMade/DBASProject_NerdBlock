namespace NerdBlock.Engine.Frontend.Winforms.Views
{
    partial class OrderPage
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
            this.btnView = new System.Windows.Forms.Button();
            this.txtOrderID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblNumberOfOrders = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dgvOrders = new NerdBlock.Engine.Frontend.Winforms.Implementation.DataGridDisplayView();
            this.clmOrderID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmOrderDaate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmOrderedBy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmTotalCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmSupplier = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmOrderLoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).BeginInit();
            this.SuspendLayout();
            // 
            // btnView
            // 
            this.btnView.Location = new System.Drawing.Point(498, 47);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(75, 23);
            this.btnView.TabIndex = 9;
            this.btnView.Text = "View";
            this.btnView.UseVisualStyleBackColor = true;
            // 
            // txtOrderID
            // 
            this.txtOrderID.Location = new System.Drawing.Point(392, 49);
            this.txtOrderID.Name = "txtOrderID";
            this.txtOrderID.Size = new System.Drawing.Size(100, 20);
            this.txtOrderID.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(339, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Order ID";
            // 
            // lblNumberOfOrders
            // 
            this.lblNumberOfOrders.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblNumberOfOrders.Location = new System.Drawing.Point(217, 51);
            this.lblNumberOfOrders.Name = "lblNumberOfOrders";
            this.lblNumberOfOrders.Size = new System.Drawing.Size(57, 13);
            this.lblNumberOfOrders.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(121, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Number of Orders";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(276, 13);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(88, 16);
            this.label9.TabIndex = 17;
            this.label9.Text = "Order Page";
            // 
            // dgvOrders
            // 
            this.dgvOrders.AllowUserToAddRows = false;
            this.dgvOrders.AllowUserToDeleteRows = false;
            this.dgvOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrders.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmOrderID,
            this.clmOrderDaate,
            this.clmOrderedBy,
            this.clmTotalCost,
            this.clmSupplier,
            this.clmOrderLoc});
            this.dgvOrders.Location = new System.Drawing.Point(33, 76);
            this.dgvOrders.Name = "dgvOrders";
            this.dgvOrders.ReadOnly = true;
            this.dgvOrders.RowHeadersVisible = false;
            this.dgvOrders.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOrders.Size = new System.Drawing.Size(607, 269);
            this.dgvOrders.TabIndex = 19;
            // 
            // clmOrderID
            // 
            this.clmOrderID.HeaderText = "Order ID";
            this.clmOrderID.Name = "clmOrderID";
            this.clmOrderID.ReadOnly = true;
            // 
            // clmOrderDaate
            // 
            this.clmOrderDaate.HeaderText = "Order Date";
            this.clmOrderDaate.Name = "clmOrderDaate";
            this.clmOrderDaate.ReadOnly = true;
            // 
            // clmOrderedBy
            // 
            this.clmOrderedBy.HeaderText = "Ordered By";
            this.clmOrderedBy.Name = "clmOrderedBy";
            this.clmOrderedBy.ReadOnly = true;
            // 
            // clmTotalCost
            // 
            this.clmTotalCost.HeaderText = "Total Cost";
            this.clmTotalCost.Name = "clmTotalCost";
            this.clmTotalCost.ReadOnly = true;
            // 
            // clmSupplier
            // 
            this.clmSupplier.HeaderText = "Supplier";
            this.clmSupplier.Name = "clmSupplier";
            this.clmSupplier.ReadOnly = true;
            // 
            // clmOrderLoc
            // 
            this.clmOrderLoc.HeaderText = "Order Location";
            this.clmOrderLoc.Name = "clmOrderLoc";
            this.clmOrderLoc.ReadOnly = true;
            // 
            // OrderPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvOrders);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.txtOrderID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblNumberOfOrders);
            this.Controls.Add(this.label1);
            this.Name = "OrderPage";
            this.Size = new System.Drawing.Size(680, 366);
            this.Load += new System.EventHandler(this.OrderPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.TextBox txtOrderID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblNumberOfOrders;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private Implementation.DataGridDisplayView dgvOrders;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmOrderID;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmOrderDaate;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmOrderedBy;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmTotalCost;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmSupplier;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmOrderLoc;
    }
}
