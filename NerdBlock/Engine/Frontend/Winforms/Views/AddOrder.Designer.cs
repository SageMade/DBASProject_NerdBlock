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
            this.label1 = new System.Windows.Forms.Label();
            this.grpOrderInfo = new System.Windows.Forms.GroupBox();
            this.cbProductID = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtProductID = new System.Windows.Forms.TextBox();
            this.grpNewProduct = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.chbNewProduct = new System.Windows.Forms.CheckBox();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtWidth = new System.Windows.Forms.TextBox();
            this.txtHeight = new System.Windows.Forms.TextBox();
            this.txtDepth = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.cbSupplierID = new System.Windows.Forms.ComboBox();
            this.grpOrderInfo.SuspendLayout();
            this.grpNewProduct.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblQuantityOrdered
            // 
            this.lblQuantityOrdered.AutoSize = true;
            this.lblQuantityOrdered.Location = new System.Drawing.Point(239, 30);
            this.lblQuantityOrdered.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblQuantityOrdered.Name = "lblQuantityOrdered";
            this.lblQuantityOrdered.Size = new System.Drawing.Size(118, 17);
            this.lblQuantityOrdered.TabIndex = 2;
            this.lblQuantityOrdered.Text = "Quantity Ordered";
            // 
            // txtQuantityOrdered
            // 
            this.txtQuantityOrdered.Location = new System.Drawing.Point(368, 26);
            this.txtQuantityOrdered.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtQuantityOrdered.Name = "txtQuantityOrdered";
            this.txtQuantityOrdered.Size = new System.Drawing.Size(120, 22);
            this.txtQuantityOrdered.TabIndex = 12;
            // 
            // btnAddOrder
            // 
            this.btnAddOrder.Location = new System.Drawing.Point(377, 172);
            this.btnAddOrder.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAddOrder.Name = "btnAddOrder";
            this.btnAddOrder.Size = new System.Drawing.Size(132, 30);
            this.btnAddOrder.TabIndex = 20;
            this.btnAddOrder.Text = "Add Order";
            this.btnAddOrder.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 25);
            this.label2.TabIndex = 25;
            this.label2.Text = "Add New Order";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 17);
            this.label1.TabIndex = 26;
            this.label1.Text = "Product ID";
            // 
            // grpOrderInfo
            // 
            this.grpOrderInfo.Controls.Add(this.cbSupplierID);
            this.grpOrderInfo.Controls.Add(this.button1);
            this.grpOrderInfo.Controls.Add(this.label6);
            this.grpOrderInfo.Controls.Add(this.cbProductID);
            this.grpOrderInfo.Controls.Add(this.lblQuantityOrdered);
            this.grpOrderInfo.Controls.Add(this.label1);
            this.grpOrderInfo.Controls.Add(this.txtQuantityOrdered);
            this.grpOrderInfo.Location = new System.Drawing.Point(14, 47);
            this.grpOrderInfo.Name = "grpOrderInfo";
            this.grpOrderInfo.Size = new System.Drawing.Size(495, 118);
            this.grpOrderInfo.TabIndex = 28;
            this.grpOrderInfo.TabStop = false;
            this.grpOrderInfo.Text = "Order Information";
            // 
            // cbProductID
            // 
            this.cbProductID.FormattingEnabled = true;
            this.cbProductID.Location = new System.Drawing.Point(103, 26);
            this.cbProductID.Name = "cbProductID";
            this.cbProductID.Size = new System.Drawing.Size(121, 24);
            this.cbProductID.TabIndex = 27;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 42);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 17);
            this.label3.TabIndex = 28;
            this.label3.Text = "Product ID";
            // 
            // txtProductID
            // 
            this.txtProductID.Location = new System.Drawing.Point(113, 42);
            this.txtProductID.Name = "txtProductID";
            this.txtProductID.Size = new System.Drawing.Size(111, 22);
            this.txtProductID.TabIndex = 29;
            // 
            // grpNewProduct
            // 
            this.grpNewProduct.Controls.Add(this.txtDescription);
            this.grpNewProduct.Controls.Add(this.txtDepth);
            this.grpNewProduct.Controls.Add(this.txtHeight);
            this.grpNewProduct.Controls.Add(this.txtWidth);
            this.grpNewProduct.Controls.Add(this.label10);
            this.grpNewProduct.Controls.Add(this.label9);
            this.grpNewProduct.Controls.Add(this.label7);
            this.grpNewProduct.Controls.Add(this.label5);
            this.grpNewProduct.Controls.Add(this.txtProductName);
            this.grpNewProduct.Controls.Add(this.label4);
            this.grpNewProduct.Controls.Add(this.txtProductID);
            this.grpNewProduct.Controls.Add(this.label3);
            this.grpNewProduct.Location = new System.Drawing.Point(14, 209);
            this.grpNewProduct.Name = "grpNewProduct";
            this.grpNewProduct.Size = new System.Drawing.Size(495, 194);
            this.grpNewProduct.TabIndex = 0;
            this.grpNewProduct.TabStop = false;
            this.grpNewProduct.Text = "New Product Information";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 72);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 17);
            this.label4.TabIndex = 30;
            this.label4.Text = "Product Name";
            // 
            // chbNewProduct
            // 
            this.chbNewProduct.AutoSize = true;
            this.chbNewProduct.Location = new System.Drawing.Point(25, 178);
            this.chbNewProduct.Name = "chbNewProduct";
            this.chbNewProduct.Size = new System.Drawing.Size(118, 21);
            this.chbNewProduct.TabIndex = 29;
            this.chbNewProduct.Text = "New Product?";
            this.chbNewProduct.UseVisualStyleBackColor = true;
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(113, 70);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(111, 22);
            this.txtProductName.TabIndex = 31;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(62, 101);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 17);
            this.label5.TabIndex = 32;
            this.label5.Text = "Width";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(57, 131);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 17);
            this.label7.TabIndex = 33;
            this.label7.Text = "Height";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(60, 160);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 17);
            this.label9.TabIndex = 34;
            this.label9.Text = "Depth";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(240, 42);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(79, 17);
            this.label10.TabIndex = 35;
            this.label10.Text = "Description";
            // 
            // txtWidth
            // 
            this.txtWidth.Location = new System.Drawing.Point(113, 101);
            this.txtWidth.Name = "txtWidth";
            this.txtWidth.Size = new System.Drawing.Size(111, 22);
            this.txtWidth.TabIndex = 36;
            // 
            // txtHeight
            // 
            this.txtHeight.Location = new System.Drawing.Point(113, 131);
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.Size = new System.Drawing.Size(111, 22);
            this.txtHeight.TabIndex = 37;
            // 
            // txtDepth
            // 
            this.txtDepth.Location = new System.Drawing.Point(113, 159);
            this.txtDepth.Name = "txtDepth";
            this.txtDepth.Size = new System.Drawing.Size(111, 22);
            this.txtDepth.TabIndex = 38;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(243, 70);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(245, 111);
            this.txtDescription.TabIndex = 39;
            this.txtDescription.Text = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 60);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 17);
            this.label6.TabIndex = 28;
            this.label6.Text = "Supplier ID";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(103, 85);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 27);
            this.button1.TabIndex = 30;
            this.button1.Text = "Add Supplier";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cbSupplierID
            // 
            this.cbSupplierID.FormattingEnabled = true;
            this.cbSupplierID.Location = new System.Drawing.Point(103, 56);
            this.cbSupplierID.Name = "cbSupplierID";
            this.cbSupplierID.Size = new System.Drawing.Size(121, 24);
            this.cbSupplierID.TabIndex = 31;
            // 
            // AddOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.chbNewProduct);
            this.Controls.Add(this.grpNewProduct);
            this.Controls.Add(this.grpOrderInfo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAddOrder);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "AddOrder";
            this.Size = new System.Drawing.Size(520, 417);
            this.Load += new System.EventHandler(this.AddOrder_Load);
            this.grpOrderInfo.ResumeLayout(false);
            this.grpOrderInfo.PerformLayout();
            this.grpNewProduct.ResumeLayout(false);
            this.grpNewProduct.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblQuantityOrdered;
        private System.Windows.Forms.TextBox txtQuantityOrdered;
        private System.Windows.Forms.Button btnAddOrder;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpOrderInfo;
        private System.Windows.Forms.ComboBox cbProductID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtProductID;
        private System.Windows.Forms.GroupBox grpNewProduct;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox chbNewProduct;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.TextBox txtDepth;
        private System.Windows.Forms.TextBox txtHeight;
        private System.Windows.Forms.TextBox txtWidth;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox txtDescription;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbSupplierID;
        private System.Windows.Forms.Button button1;
    }
}
