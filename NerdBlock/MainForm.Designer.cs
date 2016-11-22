namespace MySqlTest
{
    partial class MainForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mnuMainBar = new System.Windows.Forms.MenuStrip();
            this.tsmTasking = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmInventory = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmTickets = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmStaff = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmAdmin = new System.Windows.Forms.ToolStripMenuItem();
            this.applicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsApplicationInfo = new System.Windows.Forms.ToolStrip();
            this.pnlMainContent = new System.Windows.Forms.Panel();
            this.tslTime = new System.Windows.Forms.ToolStripLabel();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.terminateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.myTicketsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.allTicketsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.customerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.administrationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.updateToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ordersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.login1 = new MySqlTest.Login();
            this.mnuMainBar.SuspendLayout();
            this.tsApplicationInfo.SuspendLayout();
            this.pnlMainContent.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuMainBar
            // 
            this.mnuMainBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.applicationToolStripMenuItem,
            this.tsmTasking,
            this.tsmInventory,
            this.tsmTickets,
            this.tsmStaff,
            this.tsmAdmin,
            this.customerToolStripMenuItem,
            this.ordersToolStripMenuItem});
            this.mnuMainBar.Location = new System.Drawing.Point(0, 0);
            this.mnuMainBar.Name = "mnuMainBar";
            this.mnuMainBar.Size = new System.Drawing.Size(712, 24);
            this.mnuMainBar.TabIndex = 1;
            this.mnuMainBar.Text = "menuStrip1";
            // 
            // tsmTasking
            // 
            this.tsmTasking.Name = "tsmTasking";
            this.tsmTasking.Size = new System.Drawing.Size(59, 20);
            this.tsmTasking.Text = "Tasking";
            // 
            // tsmInventory
            // 
            this.tsmInventory.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.searchToolStripMenuItem3,
            this.updateToolStripMenuItem1});
            this.tsmInventory.Name = "tsmInventory";
            this.tsmInventory.Size = new System.Drawing.Size(69, 20);
            this.tsmInventory.Text = "Inventory";
            // 
            // tsmTickets
            // 
            this.tsmTickets.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.searchToolStripMenuItem1,
            this.toolStripMenuItem3,
            this.myTicketsToolStripMenuItem,
            this.allTicketsToolStripMenuItem});
            this.tsmTickets.Name = "tsmTickets";
            this.tsmTickets.Size = new System.Drawing.Size(56, 20);
            this.tsmTickets.Text = "Tickets";
            // 
            // tsmStaff
            // 
            this.tsmStaff.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.searchToolStripMenuItem,
            this.toolStripMenuItem2,
            this.addToolStripMenuItem,
            this.updateToolStripMenuItem,
            this.terminateToolStripMenuItem});
            this.tsmStaff.Name = "tsmStaff";
            this.tsmStaff.Size = new System.Drawing.Size(43, 20);
            this.tsmStaff.Text = "Staff";
            // 
            // tsmAdmin
            // 
            this.tsmAdmin.Name = "tsmAdmin";
            this.tsmAdmin.Size = new System.Drawing.Size(55, 20);
            this.tsmAdmin.Text = "Admin";
            // 
            // applicationToolStripMenuItem
            // 
            this.applicationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logoutToolStripMenuItem,
            this.toolStripMenuItem1,
            this.exitToolStripMenuItem});
            this.applicationToolStripMenuItem.Name = "applicationToolStripMenuItem";
            this.applicationToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.applicationToolStripMenuItem.Text = "Application";
            // 
            // tsApplicationInfo
            // 
            this.tsApplicationInfo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tsApplicationInfo.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tslTime});
            this.tsApplicationInfo.Location = new System.Drawing.Point(0, 560);
            this.tsApplicationInfo.Name = "tsApplicationInfo";
            this.tsApplicationInfo.Size = new System.Drawing.Size(712, 25);
            this.tsApplicationInfo.TabIndex = 2;
            this.tsApplicationInfo.Text = "toolStrip1";
            // 
            // pnlMainContent
            // 
            this.pnlMainContent.Controls.Add(this.login1);
            this.pnlMainContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMainContent.Location = new System.Drawing.Point(0, 24);
            this.pnlMainContent.Name = "pnlMainContent";
            this.pnlMainContent.Size = new System.Drawing.Size(712, 536);
            this.pnlMainContent.TabIndex = 3;
            // 
            // tslTime
            // 
            this.tslTime.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tslTime.Name = "tslTime";
            this.tslTime.Size = new System.Drawing.Size(28, 22);
            this.tslTime.Text = "0:00";
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.logoutToolStripMenuItem.Text = "Logout";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(149, 6);
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.addToolStripMenuItem.Text = "Add";
            // 
            // updateToolStripMenuItem
            // 
            this.updateToolStripMenuItem.Name = "updateToolStripMenuItem";
            this.updateToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.updateToolStripMenuItem.Text = "Update";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(149, 6);
            // 
            // terminateToolStripMenuItem
            // 
            this.terminateToolStripMenuItem.Name = "terminateToolStripMenuItem";
            this.terminateToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.terminateToolStripMenuItem.Text = "Terminate";
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.searchToolStripMenuItem.Text = "Search";
            // 
            // searchToolStripMenuItem1
            // 
            this.searchToolStripMenuItem1.Name = "searchToolStripMenuItem1";
            this.searchToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.searchToolStripMenuItem1.Text = "Search";
            // 
            // myTicketsToolStripMenuItem
            // 
            this.myTicketsToolStripMenuItem.Name = "myTicketsToolStripMenuItem";
            this.myTicketsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.myTicketsToolStripMenuItem.Text = "My Tickets";
            // 
            // allTicketsToolStripMenuItem
            // 
            this.allTicketsToolStripMenuItem.Name = "allTicketsToolStripMenuItem";
            this.allTicketsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.allTicketsToolStripMenuItem.Text = "All Tickets";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(149, 6);
            // 
            // customerToolStripMenuItem
            // 
            this.customerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.searchToolStripMenuItem2,
            this.administrationToolStripMenuItem});
            this.customerToolStripMenuItem.Name = "customerToolStripMenuItem";
            this.customerToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.customerToolStripMenuItem.Text = "Customer";
            // 
            // searchToolStripMenuItem2
            // 
            this.searchToolStripMenuItem2.Name = "searchToolStripMenuItem2";
            this.searchToolStripMenuItem2.Size = new System.Drawing.Size(152, 22);
            this.searchToolStripMenuItem2.Text = "Search";
            // 
            // administrationToolStripMenuItem
            // 
            this.administrationToolStripMenuItem.Name = "administrationToolStripMenuItem";
            this.administrationToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.administrationToolStripMenuItem.Text = "Register";
            // 
            // searchToolStripMenuItem3
            // 
            this.searchToolStripMenuItem3.Name = "searchToolStripMenuItem3";
            this.searchToolStripMenuItem3.Size = new System.Drawing.Size(152, 22);
            this.searchToolStripMenuItem3.Text = "Search";
            // 
            // updateToolStripMenuItem1
            // 
            this.updateToolStripMenuItem1.Name = "updateToolStripMenuItem1";
            this.updateToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.updateToolStripMenuItem1.Text = "Update";
            // 
            // ordersToolStripMenuItem
            // 
            this.ordersToolStripMenuItem.Name = "ordersToolStripMenuItem";
            this.ordersToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.ordersToolStripMenuItem.Text = "Orders";
            // 
            // login1
            // 
            this.login1.Location = new System.Drawing.Point(270, 205);
            this.login1.Name = "login1";
            this.login1.Size = new System.Drawing.Size(172, 126);
            this.login1.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 585);
            this.Controls.Add(this.pnlMainContent);
            this.Controls.Add(this.tsApplicationInfo);
            this.Controls.Add(this.mnuMainBar);
            this.MainMenuStrip = this.mnuMainBar;
            this.Name = "MainForm";
            this.Text = "Form1";
            this.mnuMainBar.ResumeLayout(false);
            this.mnuMainBar.PerformLayout();
            this.tsApplicationInfo.ResumeLayout(false);
            this.tsApplicationInfo.PerformLayout();
            this.pnlMainContent.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuMainBar;
        private System.Windows.Forms.ToolStripMenuItem applicationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmTasking;
        private System.Windows.Forms.ToolStripMenuItem tsmInventory;
        private System.Windows.Forms.ToolStripMenuItem tsmTickets;
        private System.Windows.Forms.ToolStripMenuItem tsmStaff;
        private System.Windows.Forms.ToolStripMenuItem tsmAdmin;
        private System.Windows.Forms.ToolStrip tsApplicationInfo;
        private System.Windows.Forms.ToolStripLabel tslTime;
        private System.Windows.Forms.Panel pnlMainContent;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem myTicketsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem allTicketsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem terminateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem administrationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ordersToolStripMenuItem;
        private Login login1;
    }
}