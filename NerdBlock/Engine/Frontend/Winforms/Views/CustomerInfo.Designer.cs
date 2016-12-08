namespace NerdBlock.Engine.Frontend.Winforms.Views
{
    partial class CustomerInfo
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
            this.grpInfo = new System.Windows.Forms.GroupBox();
            this.lblJoined = new System.Windows.Forms.Label();
            this.lblShipAdd = new System.Windows.Forms.Label();
            this.lblHomeAddr = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.grpSubscriptions = new System.Windows.Forms.GroupBox();
            this.dgvActiveSubs = new NerdBlock.Engine.Frontend.Winforms.Implementation.DataGridDisplayView();
            this.lblComingSoon = new System.Windows.Forms.Label();
            this.grpInfo.SuspendLayout();
            this.grpSubscriptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvActiveSubs)).BeginInit();
            this.SuspendLayout();
            // 
            // grpInfo
            // 
            this.grpInfo.Controls.Add(this.lblComingSoon);
            this.grpInfo.Controls.Add(this.lblJoined);
            this.grpInfo.Controls.Add(this.lblShipAdd);
            this.grpInfo.Controls.Add(this.lblHomeAddr);
            this.grpInfo.Controls.Add(this.lblLastName);
            this.grpInfo.Controls.Add(this.lblFirstName);
            this.grpInfo.Controls.Add(this.lblUserName);
            this.grpInfo.Controls.Add(this.lblEmail);
            this.grpInfo.Controls.Add(this.lblID);
            this.grpInfo.Controls.Add(this.label9);
            this.grpInfo.Controls.Add(this.label7);
            this.grpInfo.Controls.Add(this.label8);
            this.grpInfo.Controls.Add(this.label6);
            this.grpInfo.Controls.Add(this.label4);
            this.grpInfo.Controls.Add(this.label5);
            this.grpInfo.Controls.Add(this.label3);
            this.grpInfo.Controls.Add(this.label2);
            this.grpInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpInfo.Location = new System.Drawing.Point(2, 2);
            this.grpInfo.Margin = new System.Windows.Forms.Padding(2);
            this.grpInfo.Name = "grpInfo";
            this.grpInfo.Padding = new System.Windows.Forms.Padding(2);
            this.grpInfo.Size = new System.Drawing.Size(546, 158);
            this.grpInfo.TabIndex = 0;
            this.grpInfo.TabStop = false;
            this.grpInfo.Text = "Customer Information";
            this.grpInfo.Enter += new System.EventHandler(this.grpInfo_Enter);
            // 
            // lblJoined
            // 
            this.lblJoined.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblJoined.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJoined.Location = new System.Drawing.Point(361, 64);
            this.lblJoined.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblJoined.Name = "lblJoined";
            this.lblJoined.Size = new System.Drawing.Size(177, 16);
            this.lblJoined.TabIndex = 16;
            // 
            // lblShipAdd
            // 
            this.lblShipAdd.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblShipAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShipAdd.Location = new System.Drawing.Point(361, 120);
            this.lblShipAdd.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblShipAdd.Name = "lblShipAdd";
            this.lblShipAdd.Size = new System.Drawing.Size(177, 16);
            this.lblShipAdd.TabIndex = 15;
            // 
            // lblHomeAddr
            // 
            this.lblHomeAddr.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblHomeAddr.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHomeAddr.Location = new System.Drawing.Point(361, 91);
            this.lblHomeAddr.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHomeAddr.Name = "lblHomeAddr";
            this.lblHomeAddr.Size = new System.Drawing.Size(177, 16);
            this.lblHomeAddr.TabIndex = 14;
            // 
            // lblLastName
            // 
            this.lblLastName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastName.Location = new System.Drawing.Point(361, 36);
            this.lblLastName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(177, 16);
            this.lblLastName.TabIndex = 12;
            // 
            // lblFirstName
            // 
            this.lblFirstName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstName.Location = new System.Drawing.Point(86, 37);
            this.lblFirstName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(153, 16);
            this.lblFirstName.TabIndex = 11;
            // 
            // lblUserName
            // 
            this.lblUserName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.Location = new System.Drawing.Point(86, 121);
            this.lblUserName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(153, 16);
            this.lblUserName.TabIndex = 10;
            // 
            // lblEmail
            // 
            this.lblEmail.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(86, 92);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(153, 16);
            this.lblEmail.TabIndex = 9;
            // 
            // lblID
            // 
            this.lblID.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(86, 66);
            this.lblID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(66, 16);
            this.lblID.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(249, 120);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(119, 17);
            this.label9.TabIndex = 7;
            this.label9.Text = "Shipping Address";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(286, 36);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 17);
            this.label7.TabIndex = 5;
            this.label7.Text = "Last Name";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(263, 91);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(101, 17);
            this.label8.TabIndex = 6;
            this.label8.Text = "Home Address";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(11, 37);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 17);
            this.label6.TabIndex = 4;
            this.label6.Text = "First Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(310, 66);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Joined";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(11, 121);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 17);
            this.label5.TabIndex = 3;
            this.label5.Text = "User Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(44, 92);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Email";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(62, 66);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "ID";
            // 
            // grpSubscriptions
            // 
            this.grpSubscriptions.Controls.Add(this.dgvActiveSubs);
            this.grpSubscriptions.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpSubscriptions.Location = new System.Drawing.Point(2, 162);
            this.grpSubscriptions.Margin = new System.Windows.Forms.Padding(2);
            this.grpSubscriptions.Name = "grpSubscriptions";
            this.grpSubscriptions.Padding = new System.Windows.Forms.Padding(2);
            this.grpSubscriptions.Size = new System.Drawing.Size(546, 210);
            this.grpSubscriptions.TabIndex = 1;
            this.grpSubscriptions.TabStop = false;
            this.grpSubscriptions.Text = "Active Subscriptions";
            // 
            // dgvActiveSubs
            // 
            this.dgvActiveSubs.AllowUserToAddRows = false;
            this.dgvActiveSubs.AllowUserToDeleteRows = false;
            this.dgvActiveSubs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvActiveSubs.Location = new System.Drawing.Point(14, 25);
            this.dgvActiveSubs.Name = "dgvActiveSubs";
            this.dgvActiveSubs.ReadOnly = true;
            this.dgvActiveSubs.RowHeadersVisible = false;
            this.dgvActiveSubs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvActiveSubs.Size = new System.Drawing.Size(524, 180);
            this.dgvActiveSubs.TabIndex = 0;
            // 
            // lblComingSoon
            // 
            this.lblComingSoon.AutoSize = true;
            this.lblComingSoon.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComingSoon.ForeColor = System.Drawing.Color.Red;
            this.lblComingSoon.Location = new System.Drawing.Point(91, 64);
            this.lblComingSoon.Name = "lblComingSoon";
            this.lblComingSoon.Size = new System.Drawing.Size(375, 55);
            this.lblComingSoon.TabIndex = 17;
            this.lblComingSoon.Text = "COMING SOON";
            // 
            // CustomerInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grpSubscriptions);
            this.Controls.Add(this.grpInfo);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "CustomerInfo";
            this.Size = new System.Drawing.Size(554, 385);
            this.grpInfo.ResumeLayout(false);
            this.grpInfo.PerformLayout();
            this.grpSubscriptions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvActiveSubs)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpInfo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox grpSubscriptions;
        private System.Windows.Forms.Label lblJoined;
        private System.Windows.Forms.Label lblShipAdd;
        private System.Windows.Forms.Label lblHomeAddr;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblID;
        private Implementation.DataGridDisplayView dgvActiveSubs;
        private System.Windows.Forms.Label lblComingSoon;
    }
}
