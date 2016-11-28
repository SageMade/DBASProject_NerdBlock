namespace NerdBlock.Engine.Frontend.Winforms.Views
{
    partial class ContentOfBoxes
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
            this.lblOrderAmount = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblAmountShipped = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblAmountToShip = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblDeadlineDate = new System.Windows.Forms.Label();
            this.lstBoxContent = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Orders";
            // 
            // lblOrderAmount
            // 
            this.lblOrderAmount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblOrderAmount.Location = new System.Drawing.Point(81, 47);
            this.lblOrderAmount.Name = "lblOrderAmount";
            this.lblOrderAmount.Size = new System.Drawing.Size(60, 13);
            this.lblOrderAmount.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(176, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Shipped";
            // 
            // lblAmountShipped
            // 
            this.lblAmountShipped.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblAmountShipped.Location = new System.Drawing.Point(228, 47);
            this.lblAmountShipped.Name = "lblAmountShipped";
            this.lblAmountShipped.Size = new System.Drawing.Size(60, 13);
            this.lblAmountShipped.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(307, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Amount To Ship";
            // 
            // lblAmountToShip
            // 
            this.lblAmountToShip.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblAmountToShip.Location = new System.Drawing.Point(396, 47);
            this.lblAmountToShip.Name = "lblAmountToShip";
            this.lblAmountToShip.Size = new System.Drawing.Size(60, 13);
            this.lblAmountToShip.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(480, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Deadline Date for Shipping";
            // 
            // lblDeadlineDate
            // 
            this.lblDeadlineDate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDeadlineDate.Location = new System.Drawing.Point(620, 48);
            this.lblDeadlineDate.Name = "lblDeadlineDate";
            this.lblDeadlineDate.Size = new System.Drawing.Size(60, 13);
            this.lblDeadlineDate.TabIndex = 7;
            // 
            // lstBoxContent
            // 
            this.lstBoxContent.FormattingEnabled = true;
            this.lstBoxContent.Location = new System.Drawing.Point(40, 121);
            this.lstBoxContent.Name = "lstBoxContent";
            this.lstBoxContent.Size = new System.Drawing.Size(649, 251);
            this.lstBoxContent.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Product Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(179, 102);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Product ID";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(319, 102);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Quantity";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(461, 102);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Storage Location";
            // 
            // ContentOfBoxes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lstBoxContent);
            this.Controls.Add(this.lblDeadlineDate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblAmountToShip);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblAmountShipped);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblOrderAmount);
            this.Controls.Add(this.label1);
            this.Name = "ContentOfBoxes";
            this.Size = new System.Drawing.Size(718, 402);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblOrderAmount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblAmountShipped;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblAmountToShip;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblDeadlineDate;
        private System.Windows.Forms.ListBox lstBoxContent;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}
