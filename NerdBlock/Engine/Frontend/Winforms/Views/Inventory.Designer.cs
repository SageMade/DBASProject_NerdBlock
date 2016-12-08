namespace NerdBlock.Engine.Frontend.Winforms.Views
{
    partial class Inventory
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
            this.label7 = new System.Windows.Forms.Label();
            this.dataGridDisplayView1 = new NerdBlock.Engine.Frontend.Winforms.Implementation.DataGridDisplayView();
            this.clmId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmLoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDisplayView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(240, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 16);
            this.label7.TabIndex = 7;
            this.label7.Text = "Inventory";
            // 
            // dataGridDisplayView1
            // 
            this.dataGridDisplayView1.AllowUserToAddRows = false;
            this.dataGridDisplayView1.AllowUserToDeleteRows = false;
            this.dataGridDisplayView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridDisplayView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmId,
            this.clmName,
            this.clmQty,
            this.clmLoc,
            this.clmPrice});
            this.dataGridDisplayView1.Location = new System.Drawing.Point(38, 48);
            this.dataGridDisplayView1.Name = "dataGridDisplayView1";
            this.dataGridDisplayView1.ReadOnly = true;
            this.dataGridDisplayView1.RowHeadersVisible = false;
            this.dataGridDisplayView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridDisplayView1.Size = new System.Drawing.Size(504, 216);
            this.dataGridDisplayView1.TabIndex = 8;
            // 
            // clmId
            // 
            this.clmId.HeaderText = "Product ID";
            this.clmId.Name = "clmId";
            this.clmId.ReadOnly = true;
            // 
            // clmName
            // 
            this.clmName.HeaderText = "Product Name";
            this.clmName.Name = "clmName";
            this.clmName.ReadOnly = true;
            // 
            // clmQty
            // 
            this.clmQty.HeaderText = "Quantity";
            this.clmQty.Name = "clmQty";
            this.clmQty.ReadOnly = true;
            // 
            // clmLoc
            // 
            this.clmLoc.HeaderText = "Location";
            this.clmLoc.Name = "clmLoc";
            this.clmLoc.ReadOnly = true;
            // 
            // clmPrice
            // 
            this.clmPrice.HeaderText = "Price";
            this.clmPrice.Name = "clmPrice";
            this.clmPrice.ReadOnly = true;
            // 
            // Inventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridDisplayView1);
            this.Controls.Add(this.label7);
            this.Name = "Inventory";
            this.Size = new System.Drawing.Size(575, 284);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDisplayView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label7;
        private Implementation.DataGridDisplayView dataGridDisplayView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmId;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmLoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPrice;
    }
}
