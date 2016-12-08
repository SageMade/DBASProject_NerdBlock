namespace NerdBlock.Engine.Frontend.Winforms.Views
{
    partial class Blocks
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
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.grpBlockSummary = new System.Windows.Forms.GroupBox();
            this.dtpShipDate = new System.Windows.Forms.DateTimePicker();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.cbSeries = new System.Windows.Forms.ComboBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvItems = new NerdBlock.Engine.Frontend.Winforms.Implementation.DataGridDisplayView();
            this.btnSave = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.grpAddItem = new System.Windows.Forms.GroupBox();
            this.clmProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmWidth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmHeight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDepth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvAddItem = new NerdBlock.Engine.Frontend.Winforms.Implementation.DataGridDisplayView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAddProductToBlock = new System.Windows.Forms.Button();
            this.grpBlockSummary.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).BeginInit();
            this.grpAddItem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAddItem)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 52);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Series";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(2, 89);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ship Date";
            // 
            // grpBlockSummary
            // 
            this.grpBlockSummary.Controls.Add(this.dtpShipDate);
            this.grpBlockSummary.Controls.Add(this.txtDescription);
            this.grpBlockSummary.Controls.Add(this.cbSeries);
            this.grpBlockSummary.Controls.Add(this.txtTitle);
            this.grpBlockSummary.Controls.Add(this.label5);
            this.grpBlockSummary.Controls.Add(this.label6);
            this.grpBlockSummary.Controls.Add(this.label4);
            this.grpBlockSummary.Controls.Add(this.label1);
            this.grpBlockSummary.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBlockSummary.Location = new System.Drawing.Point(8, 36);
            this.grpBlockSummary.Margin = new System.Windows.Forms.Padding(2);
            this.grpBlockSummary.Name = "grpBlockSummary";
            this.grpBlockSummary.Padding = new System.Windows.Forms.Padding(2);
            this.grpBlockSummary.Size = new System.Drawing.Size(726, 138);
            this.grpBlockSummary.TabIndex = 4;
            this.grpBlockSummary.TabStop = false;
            this.grpBlockSummary.Text = "Add Block";
            // 
            // dtpShipDate
            // 
            this.dtpShipDate.Location = new System.Drawing.Point(87, 86);
            this.dtpShipDate.Name = "dtpShipDate";
            this.dtpShipDate.Size = new System.Drawing.Size(219, 23);
            this.dtpShipDate.TabIndex = 1;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(326, 45);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(395, 74);
            this.txtDescription.TabIndex = 18;
            // 
            // cbSeries
            // 
            this.cbSeries.FormattingEnabled = true;
            this.cbSeries.Location = new System.Drawing.Point(86, 51);
            this.cbSeries.Margin = new System.Windows.Forms.Padding(2);
            this.cbSeries.Name = "cbSeries";
            this.cbSeries.Size = new System.Drawing.Size(220, 25);
            this.cbSeries.TabIndex = 1;
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(86, 21);
            this.txtTitle.Margin = new System.Windows.Forms.Padding(2);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(220, 23);
            this.txtTitle.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(7, 22);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 20);
            this.label5.TabIndex = 15;
            this.label5.Text = "Title";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(322, 22);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 20);
            this.label6.TabIndex = 14;
            this.label6.Text = "Description";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvItems);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(8, 178);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(726, 273);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Products";
            // 
            // dgvItems
            // 
            this.dgvItems.AllowUserToAddRows = false;
            this.dgvItems.AllowUserToDeleteRows = false;
            this.dgvItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmProductName,
            this.clmWidth,
            this.clmHeight,
            this.clmDepth,
            this.clmDescription});
            this.dgvItems.Location = new System.Drawing.Point(5, 21);
            this.dgvItems.Name = "dgvItems";
            this.dgvItems.ReadOnly = true;
            this.dgvItems.RowHeadersVisible = false;
            this.dgvItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvItems.Size = new System.Drawing.Size(715, 238);
            this.dgvItems.TabIndex = 0;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(607, 628);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(121, 35);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(9, 14);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 20);
            this.label8.TabIndex = 15;
            this.label8.Text = "Block info";
            // 
            // grpAddItem
            // 
            this.grpAddItem.Controls.Add(this.btnAddProductToBlock);
            this.grpAddItem.Controls.Add(this.dgvAddItem);
            this.grpAddItem.Controls.Add(this.groupBox1);
            this.grpAddItem.Location = new System.Drawing.Point(8, 470);
            this.grpAddItem.Name = "grpAddItem";
            this.grpAddItem.Size = new System.Drawing.Size(726, 153);
            this.grpAddItem.TabIndex = 16;
            this.grpAddItem.TabStop = false;
            this.grpAddItem.Text = "Add Product";
            // 
            // clmProductName
            // 
            this.clmProductName.HeaderText = "Product Name";
            this.clmProductName.Name = "clmProductName";
            this.clmProductName.ReadOnly = true;
            // 
            // clmWidth
            // 
            this.clmWidth.HeaderText = "Width";
            this.clmWidth.Name = "clmWidth";
            this.clmWidth.ReadOnly = true;
            // 
            // clmHeight
            // 
            this.clmHeight.HeaderText = "Height";
            this.clmHeight.Name = "clmHeight";
            this.clmHeight.ReadOnly = true;
            // 
            // clmDepth
            // 
            this.clmDepth.HeaderText = "Depth";
            this.clmDepth.Name = "clmDepth";
            this.clmDepth.ReadOnly = true;
            // 
            // clmDescription
            // 
            this.clmDescription.HeaderText = "Description";
            this.clmDescription.Name = "clmDescription";
            this.clmDescription.ReadOnly = true;
            // 
            // dgvAddItem
            // 
            this.dgvAddItem.AllowUserToAddRows = false;
            this.dgvAddItem.AllowUserToDeleteRows = false;
            this.dgvAddItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAddItem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.dgvAddItem.Location = new System.Drawing.Point(11, 19);
            this.dgvAddItem.Name = "dgvAddItem";
            this.dgvAddItem.ReadOnly = true;
            this.dgvAddItem.RowHeadersVisible = false;
            this.dgvAddItem.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAddItem.Size = new System.Drawing.Size(503, 128);
            this.dgvAddItem.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Product Name";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Width";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Height";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Depth";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Description";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Product Name";
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(3, 38);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(100, 20);
            this.txtProductName.TabIndex = 3;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(109, 35);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtProductName);
            this.groupBox1.Location = new System.Drawing.Point(520, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(189, 67);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search Products";
            // 
            // btnAddProductToBlock
            // 
            this.btnAddProductToBlock.Location = new System.Drawing.Point(520, 94);
            this.btnAddProductToBlock.Name = "btnAddProductToBlock";
            this.btnAddProductToBlock.Size = new System.Drawing.Size(189, 42);
            this.btnAddProductToBlock.TabIndex = 6;
            this.btnAddProductToBlock.Text = "Add Product to Block";
            this.btnAddProductToBlock.UseVisualStyleBackColor = true;
            // 
            // Blocks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.grpBlockSummary);
            this.Controls.Add(this.grpAddItem);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Blocks";
            this.Size = new System.Drawing.Size(736, 671);
            this.Load += new System.EventHandler(this.AddEditBlock_Load);
            this.grpBlockSummary.ResumeLayout(false);
            this.grpBlockSummary.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).EndInit();
            this.grpAddItem.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAddItem)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox grpBlockSummary;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbSeries;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtDescription;
        private NerdBlock.Engine.Frontend.Winforms.Implementation.DataGridDisplayView dgvItems;
        private System.Windows.Forms.DateTimePicker dtpShipDate;
        private System.Windows.Forms.GroupBox grpAddItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmWidth;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmHeight;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDepth;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDescription;
        private System.Windows.Forms.Label label2;
        private Implementation.DataGridDisplayView dgvAddItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.Button btnAddProductToBlock;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtProductName;
    }
}
