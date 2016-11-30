using NerdBlock.Engine.Frontend.Winforms.Views;

namespace NerdBlock.Engine.Frontend.Winforms.Views
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
            this.applicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsiLogout = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsiExitProgram = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmTasking = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmInventory = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.updateToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmStaff = new System.Windows.Forms.ToolStripMenuItem();
            this.tsiEmployeeSearch = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsiEmployeeAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.tsiEmployeeUpdate = new System.Windows.Forms.ToolStripMenuItem();
            this.tsiEmployeeTerminate = new System.Windows.Forms.ToolStripMenuItem();
            this.customerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsiCustomerSearch = new System.Windows.Forms.ToolStripMenuItem();
            this.tsiCustomerAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.ordersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsApplicationInfo = new System.Windows.Forms.ToolStrip();
            this.tslTime = new System.Windows.Forms.ToolStripLabel();
            this.pnlMainContent = new System.Windows.Forms.Panel();
            this.addProduct1 = new NerdBlock.Engine.Frontend.Winforms.Views.AddProduct();
            this.mnuMainBar.SuspendLayout();
            this.tsApplicationInfo.SuspendLayout();
            this.pnlMainContent.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuMainBar
            // 
            this.mnuMainBar.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnuMainBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.applicationToolStripMenuItem,
            this.tsmTasking,
            this.tsmInventory,
            this.tsmStaff,
            this.customerToolStripMenuItem,
            this.ordersToolStripMenuItem});
            this.mnuMainBar.Location = new System.Drawing.Point(0, 0);
            this.mnuMainBar.Name = "mnuMainBar";
            this.mnuMainBar.Size = new System.Drawing.Size(996, 24);
            this.mnuMainBar.TabIndex = 1;
            this.mnuMainBar.Text = "menuStrip1";
            // 
            // applicationToolStripMenuItem
            // 
            this.applicationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsiLogout,
            this.toolStripMenuItem1,
            this.tsiExitProgram});
            this.applicationToolStripMenuItem.Name = "applicationToolStripMenuItem";
            this.applicationToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.applicationToolStripMenuItem.Text = "Application";
            // 
            // tsiLogout
            // 
            this.tsiLogout.Name = "tsiLogout";
            this.tsiLogout.Size = new System.Drawing.Size(112, 22);
            this.tsiLogout.Text = "Logout";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(109, 6);
            // 
            // tsiExitProgram
            // 
            this.tsiExitProgram.Name = "tsiExitProgram";
            this.tsiExitProgram.Size = new System.Drawing.Size(112, 22);
            this.tsiExitProgram.Text = "Exit";
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
            // searchToolStripMenuItem3
            // 
            this.searchToolStripMenuItem3.Name = "searchToolStripMenuItem3";
            this.searchToolStripMenuItem3.Size = new System.Drawing.Size(112, 22);
            this.searchToolStripMenuItem3.Text = "Search";
            // 
            // updateToolStripMenuItem1
            // 
            this.updateToolStripMenuItem1.Name = "updateToolStripMenuItem1";
            this.updateToolStripMenuItem1.Size = new System.Drawing.Size(112, 22);
            this.updateToolStripMenuItem1.Text = "Update";
            // 
            // tsmStaff
            // 
            this.tsmStaff.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsiEmployeeSearch,
            this.toolStripMenuItem2,
            this.tsiEmployeeAdd,
            this.tsiEmployeeUpdate,
            this.tsiEmployeeTerminate});
            this.tsmStaff.Name = "tsmStaff";
            this.tsmStaff.Size = new System.Drawing.Size(43, 20);
            this.tsmStaff.Text = "Staff";
            // 
            // tsiEmployeeSearch
            // 
            this.tsiEmployeeSearch.Name = "tsiEmployeeSearch";
            this.tsiEmployeeSearch.Size = new System.Drawing.Size(127, 22);
            this.tsiEmployeeSearch.Text = "Search";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(124, 6);
            // 
            // tsiEmployeeAdd
            // 
            this.tsiEmployeeAdd.Name = "tsiEmployeeAdd";
            this.tsiEmployeeAdd.Size = new System.Drawing.Size(127, 22);
            this.tsiEmployeeAdd.Text = "Add";
            // 
            // tsiEmployeeUpdate
            // 
            this.tsiEmployeeUpdate.Name = "tsiEmployeeUpdate";
            this.tsiEmployeeUpdate.Size = new System.Drawing.Size(127, 22);
            this.tsiEmployeeUpdate.Text = "Update";
            // 
            // tsiEmployeeTerminate
            // 
            this.tsiEmployeeTerminate.Name = "tsiEmployeeTerminate";
            this.tsiEmployeeTerminate.Size = new System.Drawing.Size(127, 22);
            this.tsiEmployeeTerminate.Text = "Terminate";
            // 
            // customerToolStripMenuItem
            // 
            this.customerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsiCustomerSearch,
            this.tsiCustomerAdd});
            this.customerToolStripMenuItem.Name = "customerToolStripMenuItem";
            this.customerToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.customerToolStripMenuItem.Text = "Customer";
            // 
            // tsiCustomerSearch
            // 
            this.tsiCustomerSearch.Name = "tsiCustomerSearch";
            this.tsiCustomerSearch.Size = new System.Drawing.Size(116, 22);
            this.tsiCustomerSearch.Text = "Search";
            // 
            // tsiCustomerAdd
            // 
            this.tsiCustomerAdd.Name = "tsiCustomerAdd";
            this.tsiCustomerAdd.Size = new System.Drawing.Size(116, 22);
            this.tsiCustomerAdd.Text = "Register";
            // 
            // ordersToolStripMenuItem
            // 
            this.ordersToolStripMenuItem.Name = "ordersToolStripMenuItem";
            this.ordersToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.ordersToolStripMenuItem.Text = "Orders";
            // 
            // tsApplicationInfo
            // 
            this.tsApplicationInfo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tsApplicationInfo.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.tsApplicationInfo.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tslTime});
            this.tsApplicationInfo.Location = new System.Drawing.Point(0, 560);
            this.tsApplicationInfo.Name = "tsApplicationInfo";
            this.tsApplicationInfo.Size = new System.Drawing.Size(996, 25);
            this.tsApplicationInfo.TabIndex = 2;
            this.tsApplicationInfo.Text = "toolStrip1";
            // 
            // tslTime
            // 
            this.tslTime.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tslTime.Name = "tslTime";
            this.tslTime.Size = new System.Drawing.Size(28, 22);
            this.tslTime.Text = "0:00";
            // 
            // pnlMainContent
            // 
            this.pnlMainContent.AutoScroll = true;
            this.pnlMainContent.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pnlMainContent.Controls.Add(this.addProduct1);
            this.pnlMainContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMainContent.Location = new System.Drawing.Point(0, 24);
            this.pnlMainContent.Name = "pnlMainContent";
            this.pnlMainContent.Size = new System.Drawing.Size(996, 536);
            this.pnlMainContent.TabIndex = 3;
            // 
            // addProduct1
            // 
            this.addProduct1.Location = new System.Drawing.Point(274, 148);
            this.addProduct1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.addProduct1.Name = "addProduct1";
            this.addProduct1.Size = new System.Drawing.Size(431, 223);
            this.addProduct1.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(996, 585);
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
        private System.Windows.Forms.ToolStripMenuItem tsmStaff;
        private System.Windows.Forms.ToolStrip tsApplicationInfo;
        private System.Windows.Forms.ToolStripLabel tslTime;
        private System.Windows.Forms.Panel pnlMainContent;
        private System.Windows.Forms.ToolStripMenuItem tsiLogout;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem tsiExitProgram;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem tsiEmployeeSearch;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem tsiEmployeeAdd;
        private System.Windows.Forms.ToolStripMenuItem tsiEmployeeUpdate;
        private System.Windows.Forms.ToolStripMenuItem tsiEmployeeTerminate;
        private System.Windows.Forms.ToolStripMenuItem customerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsiCustomerSearch;
        private System.Windows.Forms.ToolStripMenuItem tsiCustomerAdd;
        private System.Windows.Forms.ToolStripMenuItem ordersToolStripMenuItem;
        private AddProduct addProduct1;
    }
}