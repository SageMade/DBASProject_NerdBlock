namespace NerdBlock.Engine.Frontend.Winforms.Views
{
    partial class BlockQueries
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
            this.label6 = new System.Windows.Forms.Label();
            this.cbGenre = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbSeries = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.grpSeries = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnEdit = new System.Windows.Forms.Button();
            this.dgvData = new NerdBlock.Engine.Frontend.Winforms.Implementation.DataGridDisplayView();
            this.clmBlockId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmMonth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmYear = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPurchased = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmShipped = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpSeries.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(112, 43);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Genre";
            // 
            // cbGenre
            // 
            this.cbGenre.DropDownWidth = 200;
            this.cbGenre.FormattingEnabled = true;
            this.cbGenre.Location = new System.Drawing.Point(153, 40);
            this.cbGenre.Margin = new System.Windows.Forms.Padding(2);
            this.cbGenre.Name = "cbGenre";
            this.cbGenre.Size = new System.Drawing.Size(126, 21);
            this.cbGenre.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(284, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Series";
            // 
            // cbSeries
            // 
            this.cbSeries.DropDownWidth = 200;
            this.cbSeries.FormattingEnabled = true;
            this.cbSeries.Location = new System.Drawing.Point(325, 40);
            this.cbSeries.Margin = new System.Windows.Forms.Padding(2);
            this.cbSeries.Name = "cbSeries";
            this.cbSeries.Size = new System.Drawing.Size(124, 21);
            this.cbSeries.TabIndex = 13;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(223, 299);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(110, 23);
            this.btnAdd.TabIndex = 18;
            this.btnAdd.Text = "Add Block";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // grpSeries
            // 
            this.grpSeries.Controls.Add(this.dgvData);
            this.grpSeries.Location = new System.Drawing.Point(18, 66);
            this.grpSeries.Name = "grpSeries";
            this.grpSeries.Size = new System.Drawing.Size(434, 227);
            this.grpSeries.TabIndex = 16;
            this.grpSeries.TabStop = false;
            this.grpSeries.Text = "Series";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(6, 8);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(102, 20);
            this.label8.TabIndex = 14;
            this.label8.Text = "Query Blocks";
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(339, 299);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(110, 23);
            this.btnEdit.TabIndex = 19;
            this.btnEdit.Text = "Edit Block";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // dgvData
            // 
            this.dgvData.AllowUserToAddRows = false;
            this.dgvData.AllowUserToDeleteRows = false;
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmBlockId,
            this.clmMonth,
            this.clmYear,
            this.clmPurchased,
            this.clmShipped});
            this.dgvData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvData.Location = new System.Drawing.Point(3, 16);
            this.dgvData.Name = "dgvData";
            this.dgvData.ReadOnly = true;
            this.dgvData.RowHeadersVisible = false;
            this.dgvData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvData.Size = new System.Drawing.Size(428, 208);
            this.dgvData.TabIndex = 0;
            // 
            // clmBlockId
            // 
            this.clmBlockId.HeaderText = "BlockId";
            this.clmBlockId.Name = "clmBlockId";
            this.clmBlockId.ReadOnly = true;
            this.clmBlockId.Visible = false;
            // 
            // clmMonth
            // 
            this.clmMonth.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmMonth.DataPropertyName = "Month";
            this.clmMonth.FillWeight = 15F;
            this.clmMonth.HeaderText = "Month";
            this.clmMonth.Name = "clmMonth";
            this.clmMonth.ReadOnly = true;
            // 
            // clmYear
            // 
            this.clmYear.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmYear.DataPropertyName = "Year";
            this.clmYear.FillWeight = 15F;
            this.clmYear.HeaderText = "Year";
            this.clmYear.Name = "clmYear";
            this.clmYear.ReadOnly = true;
            // 
            // clmPurchased
            // 
            this.clmPurchased.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmPurchased.DataPropertyName = "Purchased";
            this.clmPurchased.FillWeight = 25F;
            this.clmPurchased.HeaderText = "Purchased";
            this.clmPurchased.Name = "clmPurchased";
            this.clmPurchased.ReadOnly = true;
            // 
            // clmShipped
            // 
            this.clmShipped.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmShipped.DataPropertyName = "Shipped";
            this.clmShipped.FillWeight = 25F;
            this.clmShipped.HeaderText = "Shipped";
            this.clmShipped.Name = "clmShipped";
            this.clmShipped.ReadOnly = true;
            // 
            // BlockQueries
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.grpSeries);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbSeries);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbGenre);
            this.Name = "BlockQueries";
            this.Size = new System.Drawing.Size(455, 329);
            this.grpSeries.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbGenre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbSeries;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.GroupBox grpSeries;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnEdit;
        private Implementation.DataGridDisplayView dgvData;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmBlockId;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmMonth;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmYear;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPurchased;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmShipped;
    }
}
