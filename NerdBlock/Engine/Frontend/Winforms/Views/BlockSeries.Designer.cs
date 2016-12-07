namespace NerdBlock.Engine.Frontend.Winforms.Views
{
    partial class BlockSeries
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
            this.grpSeries = new System.Windows.Forms.GroupBox();
            this.cbGenre = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnBlocks = new System.Windows.Forms.Button();
            this.dataGridDisplayView1 = new NerdBlock.Engine.Frontend.Winforms.Implementation.DataGridDisplayView();
            this.clmName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmSize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmSubsribers = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpSeries.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDisplayView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(17, 23);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Series Info";
            // 
            // grpSeries
            // 
            this.grpSeries.Controls.Add(this.dataGridDisplayView1);
            this.grpSeries.Location = new System.Drawing.Point(21, 53);
            this.grpSeries.Name = "grpSeries";
            this.grpSeries.Size = new System.Drawing.Size(332, 256);
            this.grpSeries.TabIndex = 8;
            this.grpSeries.TabStop = false;
            this.grpSeries.Text = "Series";
            // 
            // cbGenre
            // 
            this.cbGenre.FormattingEnabled = true;
            this.cbGenre.Location = new System.Drawing.Point(251, 27);
            this.cbGenre.Margin = new System.Windows.Forms.Padding(2);
            this.cbGenre.Name = "cbGenre";
            this.cbGenre.Size = new System.Drawing.Size(102, 21);
            this.cbGenre.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(206, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Genre";
            // 
            // btnBlocks
            // 
            this.btnBlocks.Location = new System.Drawing.Point(243, 315);
            this.btnBlocks.Name = "btnBlocks";
            this.btnBlocks.Size = new System.Drawing.Size(110, 23);
            this.btnBlocks.TabIndex = 10;
            this.btnBlocks.Text = "View Blocks";
            this.btnBlocks.UseVisualStyleBackColor = true;
            // 
            // dataGridDisplayView1
            // 
            this.dataGridDisplayView1.AllowUserToAddRows = false;
            this.dataGridDisplayView1.AllowUserToDeleteRows = false;
            this.dataGridDisplayView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridDisplayView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmName,
            this.clmPrice,
            this.clmSize,
            this.clmSubsribers});
            this.dataGridDisplayView1.Location = new System.Drawing.Point(6, 19);
            this.dataGridDisplayView1.Name = "dataGridDisplayView1";
            this.dataGridDisplayView1.ReadOnly = true;
            this.dataGridDisplayView1.RowHeadersVisible = false;
            this.dataGridDisplayView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridDisplayView1.Size = new System.Drawing.Size(320, 231);
            this.dataGridDisplayView1.TabIndex = 8;
            // 
            // clmName
            // 
            this.clmName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmName.DataPropertyName = "Name";
            this.clmName.FillWeight = 40F;
            this.clmName.HeaderText = "Series Name";
            this.clmName.Name = "clmName";
            this.clmName.ReadOnly = true;
            // 
            // clmPrice
            // 
            this.clmPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmPrice.DataPropertyName = "Price";
            this.clmPrice.FillWeight = 20F;
            this.clmPrice.HeaderText = "Price";
            this.clmPrice.Name = "clmPrice";
            this.clmPrice.ReadOnly = true;
            // 
            // clmSize
            // 
            this.clmSize.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmSize.DataPropertyName = "Volume";
            this.clmSize.FillWeight = 20F;
            this.clmSize.HeaderText = "Size cm³";
            this.clmSize.Name = "clmSize";
            this.clmSize.ReadOnly = true;
            // 
            // clmSubsribers
            // 
            this.clmSubsribers.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmSubsribers.DataPropertyName = "Subsribers";
            this.clmSubsribers.FillWeight = 20F;
            this.clmSubsribers.HeaderText = "Subscribers";
            this.clmSubsribers.Name = "clmSubsribers";
            this.clmSubsribers.ReadOnly = true;
            // 
            // BlockSeries
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnBlocks);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbGenre);
            this.Controls.Add(this.grpSeries);
            this.Controls.Add(this.label5);
            this.Name = "BlockSeries";
            this.Size = new System.Drawing.Size(368, 345);
            this.grpSeries.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDisplayView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox grpSeries;
        private System.Windows.Forms.ComboBox cbGenre;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnBlocks;
        private Implementation.DataGridDisplayView dataGridDisplayView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmSize;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmSubsribers;
    }
}
