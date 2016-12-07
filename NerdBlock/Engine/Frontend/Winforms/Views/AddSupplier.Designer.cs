namespace NerdBlock.Engine.Frontend.Winforms.Views
{
    partial class AddSupplier
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
            this.lblAddSupplier = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCompany = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtFirst = new System.Windows.Forms.TextBox();
            this.txtLast = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.grpContact = new System.Windows.Forms.GroupBox();
            this.txtContactPhone = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.grpCompany = new System.Windows.Forms.GroupBox();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.adrInCompany = new NerdBlock.Engine.Frontend.Winforms.Implementation.AddressEntry();
            this.grpContact.SuspendLayout();
            this.grpCompany.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblAddSupplier
            // 
            this.lblAddSupplier.AutoSize = true;
            this.lblAddSupplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddSupplier.Location = new System.Drawing.Point(10, 10);
            this.lblAddSupplier.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAddSupplier.Name = "lblAddSupplier";
            this.lblAddSupplier.Size = new System.Drawing.Size(100, 20);
            this.lblAddSupplier.TabIndex = 0;
            this.lblAddSupplier.Text = "Add Supplier";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 21);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Company";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 22);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "First name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 46);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Last Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 45);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Phone Number";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(56, 71);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Email";
            // 
            // txtCompany
            // 
            this.txtCompany.Location = new System.Drawing.Point(111, 18);
            this.txtCompany.Margin = new System.Windows.Forms.Padding(2);
            this.txtCompany.Name = "txtCompany";
            this.txtCompany.Size = new System.Drawing.Size(150, 20);
            this.txtCompany.TabIndex = 8;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(111, 42);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(2);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(150, 20);
            this.txtPhone.TabIndex = 9;
            // 
            // txtFirst
            // 
            this.txtFirst.Location = new System.Drawing.Point(97, 19);
            this.txtFirst.Margin = new System.Windows.Forms.Padding(2);
            this.txtFirst.Name = "txtFirst";
            this.txtFirst.Size = new System.Drawing.Size(92, 20);
            this.txtFirst.TabIndex = 10;
            // 
            // txtLast
            // 
            this.txtLast.Location = new System.Drawing.Point(97, 43);
            this.txtLast.Margin = new System.Windows.Forms.Padding(2);
            this.txtLast.Name = "txtLast";
            this.txtLast.Size = new System.Drawing.Size(92, 20);
            this.txtLast.TabIndex = 11;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(97, 68);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(2);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(92, 20);
            this.txtEmail.TabIndex = 12;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(412, 232);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(92, 28);
            this.btnAdd.TabIndex = 13;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // grpContact
            // 
            this.grpContact.Controls.Add(this.txtContactPhone);
            this.grpContact.Controls.Add(this.label1);
            this.grpContact.Controls.Add(this.txtEmail);
            this.grpContact.Controls.Add(this.label3);
            this.grpContact.Controls.Add(this.label4);
            this.grpContact.Controls.Add(this.txtLast);
            this.grpContact.Controls.Add(this.label6);
            this.grpContact.Controls.Add(this.txtFirst);
            this.grpContact.Location = new System.Drawing.Point(292, 33);
            this.grpContact.Name = "grpContact";
            this.grpContact.Size = new System.Drawing.Size(212, 128);
            this.grpContact.TabIndex = 14;
            this.grpContact.TabStop = false;
            this.grpContact.Text = "Contact";
            // 
            // txtContactPhone
            // 
            this.txtContactPhone.Location = new System.Drawing.Point(97, 92);
            this.txtContactPhone.Margin = new System.Windows.Forms.Padding(2);
            this.txtContactPhone.Name = "txtContactPhone";
            this.txtContactPhone.Size = new System.Drawing.Size(92, 20);
            this.txtContactPhone.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 94);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Phone Number";
            // 
            // grpCompany
            // 
            this.grpCompany.Controls.Add(this.adrInCompany);
            this.grpCompany.Controls.Add(this.txtCompany);
            this.grpCompany.Controls.Add(this.label2);
            this.grpCompany.Controls.Add(this.txtPhone);
            this.grpCompany.Controls.Add(this.label5);
            this.grpCompany.Location = new System.Drawing.Point(6, 33);
            this.grpCompany.Name = "grpCompany";
            this.grpCompany.Size = new System.Drawing.Size(280, 233);
            this.grpCompany.TabIndex = 15;
            this.grpCompany.TabStop = false;
            this.grpCompany.Text = "Company";
            // 
            // adrInCompany
            // 
            this.adrInCompany.Location = new System.Drawing.Point(5, 67);
            this.adrInCompany.Name = "adrInCompany";
            this.adrInCompany.Prefix = null;
            this.adrInCompany.Size = new System.Drawing.Size(259, 160);
            this.adrInCompany.TabIndex = 10;
            // 
            // AddSupplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grpCompany);
            this.Controls.Add(this.grpContact);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblAddSupplier);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AddSupplier";
            this.Size = new System.Drawing.Size(520, 272);
            this.grpContact.ResumeLayout(false);
            this.grpContact.PerformLayout();
            this.grpCompany.ResumeLayout(false);
            this.grpCompany.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAddSupplier;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCompany;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtFirst;
        private System.Windows.Forms.TextBox txtLast;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.GroupBox grpContact;
        private System.Windows.Forms.TextBox txtContactPhone;
        private System.Windows.Forms.Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox grpCompany;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private Implementation.AddressEntry adrInCompany;
    }
}
