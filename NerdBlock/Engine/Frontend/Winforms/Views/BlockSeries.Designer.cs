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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.grpSeries = new System.Windows.Forms.GroupBox();
            this.cbGenre = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lbSeries = new System.Windows.Forms.ListBox();
            this.btnBlocks = new System.Windows.Forms.Button();
            this.grpSeries.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Series Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(84, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Sub Price";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(191, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "# of Current Subscribers";
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
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(143, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Volume";
            // 
            // grpSeries
            // 
            this.grpSeries.Controls.Add(this.lbSeries);
            this.grpSeries.Controls.Add(this.label3);
            this.grpSeries.Controls.Add(this.label1);
            this.grpSeries.Controls.Add(this.label2);
            this.grpSeries.Controls.Add(this.label4);
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
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // lbSeries
            // 
            this.lbSeries.FormattingEnabled = true;
            this.lbSeries.Location = new System.Drawing.Point(14, 54);
            this.lbSeries.Name = "lbSeries";
            this.lbSeries.Size = new System.Drawing.Size(298, 186);
            this.lbSeries.TabIndex = 8;
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
            this.grpSeries.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox grpSeries;
        private System.Windows.Forms.ListBox lbSeries;
        private System.Windows.Forms.ComboBox cbGenre;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnBlocks;
    }
}
