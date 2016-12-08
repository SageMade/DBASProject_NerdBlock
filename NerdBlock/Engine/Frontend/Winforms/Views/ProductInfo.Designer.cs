namespace NerdBlock.Engine.Frontend.Winforms.Views
{
    partial class ProductInfo
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
            this.lblProductName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtProdName = new System.Windows.Forms.TextBox();
            this.txtProdLength = new System.Windows.Forms.TextBox();
            this.txtProdWidth = new System.Windows.Forms.TextBox();
            this.txtProdHeight = new System.Windows.Forms.TextBox();
            this.btnEdit = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtProdDesc = new System.Windows.Forms.TextBox();
            this.lblComingSoon = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Location = new System.Drawing.Point(19, 49);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(75, 13);
            this.lblProductName.TabIndex = 0;
            this.lblProductName.Text = "Product Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(145, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Product Description";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Length";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Width";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Heigth";
            // 
            // txtProdName
            // 
            this.txtProdName.Location = new System.Drawing.Point(22, 75);
            this.txtProdName.Name = "txtProdName";
            this.txtProdName.Size = new System.Drawing.Size(100, 20);
            this.txtProdName.TabIndex = 10;
            // 
            // txtProdLength
            // 
            this.txtProdLength.Location = new System.Drawing.Point(22, 118);
            this.txtProdLength.Name = "txtProdLength";
            this.txtProdLength.Size = new System.Drawing.Size(100, 20);
            this.txtProdLength.TabIndex = 11;
            // 
            // txtProdWidth
            // 
            this.txtProdWidth.Location = new System.Drawing.Point(22, 164);
            this.txtProdWidth.Name = "txtProdWidth";
            this.txtProdWidth.Size = new System.Drawing.Size(100, 20);
            this.txtProdWidth.TabIndex = 12;
            // 
            // txtProdHeight
            // 
            this.txtProdHeight.Location = new System.Drawing.Point(24, 203);
            this.txtProdHeight.Name = "txtProdHeight";
            this.txtProdHeight.Size = new System.Drawing.Size(100, 20);
            this.txtProdHeight.TabIndex = 13;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(340, 203);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 14;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(19, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 16);
            this.label3.TabIndex = 15;
            this.label3.Text = "View and Edit Product";
            // 
            // txtProdDesc
            // 
            this.txtProdDesc.Location = new System.Drawing.Point(148, 75);
            this.txtProdDesc.Multiline = true;
            this.txtProdDesc.Name = "txtProdDesc";
            this.txtProdDesc.Size = new System.Drawing.Size(267, 122);
            this.txtProdDesc.TabIndex = 16;
            // 
            // lblComingSoon
            // 
            this.lblComingSoon.AutoSize = true;
            this.lblComingSoon.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComingSoon.ForeColor = System.Drawing.Color.Red;
            this.lblComingSoon.Location = new System.Drawing.Point(28, 92);
            this.lblComingSoon.Name = "lblComingSoon";
            this.lblComingSoon.Size = new System.Drawing.Size(375, 55);
            this.lblComingSoon.TabIndex = 18;
            this.lblComingSoon.Text = "COMING SOON";
            // 
            // ProductInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblComingSoon);
            this.Controls.Add(this.txtProdDesc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.txtProdHeight);
            this.Controls.Add(this.txtProdWidth);
            this.Controls.Add(this.txtProdLength);
            this.Controls.Add(this.txtProdName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblProductName);
            this.Name = "ProductInfo";
            this.Size = new System.Drawing.Size(431, 239);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtProdName;
        private System.Windows.Forms.TextBox txtProdLength;
        private System.Windows.Forms.TextBox txtProdWidth;
        private System.Windows.Forms.TextBox txtProdHeight;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtProdDesc;
        private System.Windows.Forms.Label lblComingSoon;
    }
}
