namespace NerdBlock.Engine.Frontend.Winforms.Views
{
    partial class BlockGenres
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvGenres = new System.Windows.Forms.DataGridView();
            this.clmName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmlActive = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.clmSeriesCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnViewSeries = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGenres)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 8);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Block Genres";
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.Location = new System.Drawing.Point(293, 125);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(71, 19);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "Add Genre";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvGenres);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(8, 28);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(368, 264);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "View Genres";
            // 
            // dgvGenres
            // 
            this.dgvGenres.AllowUserToAddRows = false;
            this.dgvGenres.AllowUserToDeleteRows = false;
            this.dgvGenres.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGenres.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmName,
            this.cmlActive,
            this.clmSeriesCount});
            this.dgvGenres.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvGenres.Location = new System.Drawing.Point(2, 15);
            this.dgvGenres.Name = "dgvGenres";
            this.dgvGenres.ReadOnly = true;
            this.dgvGenres.RowHeadersVisible = false;
            this.dgvGenres.Size = new System.Drawing.Size(364, 213);
            this.dgvGenres.TabIndex = 0;
            // 
            // clmName
            // 
            this.clmName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmName.DataPropertyName = "Name";
            this.clmName.FillWeight = 65F;
            this.clmName.HeaderText = "Name";
            this.clmName.Name = "clmName";
            this.clmName.ReadOnly = true;
            // 
            // cmlActive
            // 
            this.cmlActive.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cmlActive.DataPropertyName = "IsActive";
            this.cmlActive.FillWeight = 15F;
            this.cmlActive.HeaderText = "Active";
            this.cmlActive.Name = "cmlActive";
            this.cmlActive.ReadOnly = true;
            this.cmlActive.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.cmlActive.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // clmSeriesCount
            // 
            this.clmSeriesCount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmSeriesCount.DataPropertyName = "SeriesCount";
            this.clmSeriesCount.FillWeight = 20F;
            this.clmSeriesCount.HeaderText = "# of Series";
            this.clmSeriesCount.Name = "clmSeriesCount";
            this.clmSeriesCount.ReadOnly = true;
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.Controls.Add(this.btnViewSeries);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(2, 228);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(4);
            this.panel1.Size = new System.Drawing.Size(364, 34);
            this.panel1.TabIndex = 2;
            // 
            // btnViewSeries
            // 
            this.btnViewSeries.Location = new System.Drawing.Point(255, 5);
            this.btnViewSeries.Margin = new System.Windows.Forms.Padding(2);
            this.btnViewSeries.Name = "btnViewSeries";
            this.btnViewSeries.Size = new System.Drawing.Size(103, 23);
            this.btnViewSeries.TabIndex = 14;
            this.btnViewSeries.Text = "View Series Info";
            this.btnViewSeries.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.txtDescription);
            this.groupBox3.Controls.Add(this.txtTitle);
            this.groupBox3.Controls.Add(this.btnAdd);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox3.Location = new System.Drawing.Point(8, 292);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(368, 148);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "New Genre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 62);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Description";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 30);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Title";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(69, 62);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(2);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(295, 53);
            this.txtDescription.TabIndex = 12;
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(69, 30);
            this.txtTitle.Margin = new System.Windows.Forms.Padding(2);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(179, 20);
            this.txtTitle.TabIndex = 11;
            // 
            // BlockGenres
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label1);
            this.Name = "BlockGenres";
            this.Padding = new System.Windows.Forms.Padding(8);
            this.Size = new System.Drawing.Size(384, 448);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGenres)).EndInit();
            this.panel1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.DataGridView dgvGenres;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmName;
        private System.Windows.Forms.DataGridViewCheckBoxColumn cmlActive;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmSeriesCount;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnViewSeries;
    }
}
