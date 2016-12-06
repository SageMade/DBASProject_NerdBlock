namespace NerdBlock.Engine.Frontend.Winforms.Views
{
    partial class FloorWorkerGenres
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
            this.dgvGenres = new System.Windows.Forms.DataGridView();
            this.clmName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmlActive = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.clmSeriesCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnViewGenre = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGenres)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(170, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Worker Genre View";
            // 
            // dgvGenres
            // 
            this.dgvGenres.AllowUserToAddRows = false;
            this.dgvGenres.AllowUserToDeleteRows = false;
            this.dgvGenres.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.dgvGenres.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGenres.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmName,
            this.cmlActive,
            this.clmSeriesCount});
            this.dgvGenres.Location = new System.Drawing.Point(51, 53);
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
            // btnViewGenre
            // 
            this.btnViewGenre.Location = new System.Drawing.Point(340, 272);
            this.btnViewGenre.Name = "btnViewGenre";
            this.btnViewGenre.Size = new System.Drawing.Size(75, 23);
            this.btnViewGenre.TabIndex = 1;
            this.btnViewGenre.Text = "View Genre";
            this.btnViewGenre.UseVisualStyleBackColor = true;
            // 
            // FloorWorkerGenres
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnViewGenre);
            this.Controls.Add(this.dgvGenres);
            this.Controls.Add(this.label1);
            this.Name = "FloorWorkerGenres";
            this.Size = new System.Drawing.Size(488, 368);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGenres)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvGenres;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmName;
        private System.Windows.Forms.DataGridViewCheckBoxColumn cmlActive;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmSeriesCount;
        private System.Windows.Forms.Button btnViewGenre;
    }
}
