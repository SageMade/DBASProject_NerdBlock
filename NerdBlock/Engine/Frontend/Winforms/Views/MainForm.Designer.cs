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
            this.components = new System.ComponentModel.Container();
            this.mnuMainBar = new System.Windows.Forms.MenuStrip();
            this.applicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsiLogin = new System.Windows.Forms.ToolStripMenuItem();
            this.tsiChangePassword = new System.Windows.Forms.ToolStripMenuItem();
            this.tsiLogout = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsiExitProgram = new System.Windows.Forms.ToolStripMenuItem();
            this.tsiBlocks = new System.Windows.Forms.ToolStripMenuItem();
            this.tsiBlocksAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.tsiBlocksGenres = new System.Windows.Forms.ToolStripMenuItem();
            this.tsiBlocksQueries = new System.Windows.Forms.ToolStripMenuItem();
            this.tsiBlocksSeries = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmInventory = new System.Windows.Forms.ToolStripMenuItem();
            this.tsiInventorySearch = new System.Windows.Forms.ToolStripMenuItem();
            this.tsiInventoryAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.tsiInventoryLostDamaged = new System.Windows.Forms.ToolStripMenuItem();
            this.tsiInventoryOverstock = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmStaff = new System.Windows.Forms.ToolStripMenuItem();
            this.tsiEmployeeSearch = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsiEmployeeAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.customerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsiCustomerSearch = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmOrders = new System.Windows.Forms.ToolStripMenuItem();
            this.tsiAddOrder = new System.Windows.Forms.ToolStripMenuItem();
            this.tsiSearchOrders = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmReports = new System.Windows.Forms.ToolStripMenuItem();
            this.tsiEmployeeBreakdown = new System.Windows.Forms.ToolStripMenuItem();
            this.tsiSeriesBreakdown = new System.Windows.Forms.ToolStripMenuItem();
            this.tsiInventoryBreakdown = new System.Windows.Forms.ToolStripMenuItem();
            this.tsApplicationInfo = new System.Windows.Forms.ToolStrip();
            this.tslTime = new System.Windows.Forms.ToolStripLabel();
            this.pnlMainContent = new System.Windows.Forms.Panel();
            this.tmrWatch = new System.Windows.Forms.Timer(this.components);
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
            this.tsiBlocks,
            this.tsmInventory,
            this.tsmStaff,
            this.customerToolStripMenuItem,
            this.tsmOrders,
            this.tsmReports});
            this.mnuMainBar.Location = new System.Drawing.Point(0, 0);
            this.mnuMainBar.Name = "mnuMainBar";
            this.mnuMainBar.Size = new System.Drawing.Size(996, 24);
            this.mnuMainBar.TabIndex = 1;
            this.mnuMainBar.Text = "menuStrip1";
            // 
            // applicationToolStripMenuItem
            // 
            this.applicationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsiLogin,
            this.tsiChangePassword,
            this.tsiLogout,
            this.toolStripMenuItem1,
            this.tsiExitProgram});
            this.applicationToolStripMenuItem.Name = "applicationToolStripMenuItem";
            this.applicationToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.applicationToolStripMenuItem.Text = "Application";
            // 
            // tsiLogin
            // 
            this.tsiLogin.Name = "tsiLogin";
            this.tsiLogin.Size = new System.Drawing.Size(168, 22);
            this.tsiLogin.Text = "Login";
            // 
            // tsiChangePassword
            // 
            this.tsiChangePassword.Name = "tsiChangePassword";
            this.tsiChangePassword.Size = new System.Drawing.Size(168, 22);
            this.tsiChangePassword.Text = "Change Password";
            // 
            // tsiLogout
            // 
            this.tsiLogout.Name = "tsiLogout";
            this.tsiLogout.Size = new System.Drawing.Size(168, 22);
            this.tsiLogout.Text = "Logout";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(165, 6);
            // 
            // tsiExitProgram
            // 
            this.tsiExitProgram.Name = "tsiExitProgram";
            this.tsiExitProgram.Size = new System.Drawing.Size(168, 22);
            this.tsiExitProgram.Text = "Exit";
            // 
            // tsiBlocks
            // 
            this.tsiBlocks.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsiBlocksAdd,
            this.tsiBlocksGenres,
            this.tsiBlocksQueries,
            this.tsiBlocksSeries});
            this.tsiBlocks.Name = "tsiBlocks";
            this.tsiBlocks.Size = new System.Drawing.Size(53, 20);
            this.tsiBlocks.Text = "Blocks";
            // 
            // tsiBlocksAdd
            // 
            this.tsiBlocksAdd.Name = "tsiBlocksAdd";
            this.tsiBlocksAdd.Size = new System.Drawing.Size(114, 22);
            this.tsiBlocksAdd.Text = "Add";
            // 
            // tsiBlocksGenres
            // 
            this.tsiBlocksGenres.Name = "tsiBlocksGenres";
            this.tsiBlocksGenres.Size = new System.Drawing.Size(114, 22);
            this.tsiBlocksGenres.Text = "Genres";
            // 
            // tsiBlocksQueries
            // 
            this.tsiBlocksQueries.Name = "tsiBlocksQueries";
            this.tsiBlocksQueries.Size = new System.Drawing.Size(114, 22);
            this.tsiBlocksQueries.Text = "Queries";
            // 
            // tsiBlocksSeries
            // 
            this.tsiBlocksSeries.Name = "tsiBlocksSeries";
            this.tsiBlocksSeries.Size = new System.Drawing.Size(114, 22);
            this.tsiBlocksSeries.Text = "Series";
            // 
            // tsmInventory
            // 
            this.tsmInventory.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsiInventorySearch,
            this.tsiInventoryAdd,
            this.tsiInventoryLostDamaged,
            this.tsiInventoryOverstock});
            this.tsmInventory.Name = "tsmInventory";
            this.tsmInventory.Size = new System.Drawing.Size(69, 20);
            this.tsmInventory.Text = "Inventory";
            // 
            // tsiInventorySearch
            // 
            this.tsiInventorySearch.Name = "tsiInventorySearch";
            this.tsiInventorySearch.Size = new System.Drawing.Size(152, 22);
            this.tsiInventorySearch.Text = "Search";
            // 
            // tsiInventoryAdd
            // 
            this.tsiInventoryAdd.Name = "tsiInventoryAdd";
            this.tsiInventoryAdd.Size = new System.Drawing.Size(152, 22);
            this.tsiInventoryAdd.Text = "Add";
            // 
            // tsiInventoryLostDamaged
            // 
            this.tsiInventoryLostDamaged.Name = "tsiInventoryLostDamaged";
            this.tsiInventoryLostDamaged.Size = new System.Drawing.Size(152, 22);
            this.tsiInventoryLostDamaged.Text = "Lost/Damaged";
            // 
            // tsiInventoryOverstock
            // 
            this.tsiInventoryOverstock.Name = "tsiInventoryOverstock";
            this.tsiInventoryOverstock.Size = new System.Drawing.Size(152, 22);
            this.tsiInventoryOverstock.Text = "Overstock";
            // 
            // tsmStaff
            // 
            this.tsmStaff.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsiEmployeeSearch,
            this.toolStripMenuItem2,
            this.tsiEmployeeAdd});
            this.tsmStaff.Name = "tsmStaff";
            this.tsmStaff.Size = new System.Drawing.Size(43, 20);
            this.tsmStaff.Text = "Staff";
            // 
            // tsiEmployeeSearch
            // 
            this.tsiEmployeeSearch.Name = "tsiEmployeeSearch";
            this.tsiEmployeeSearch.Size = new System.Drawing.Size(109, 22);
            this.tsiEmployeeSearch.Text = "Search";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(106, 6);
            // 
            // tsiEmployeeAdd
            // 
            this.tsiEmployeeAdd.Name = "tsiEmployeeAdd";
            this.tsiEmployeeAdd.Size = new System.Drawing.Size(109, 22);
            this.tsiEmployeeAdd.Text = "Add";
            // 
            // customerToolStripMenuItem
            // 
            this.customerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsiCustomerSearch});
            this.customerToolStripMenuItem.Name = "customerToolStripMenuItem";
            this.customerToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.customerToolStripMenuItem.Text = "Customer";
            // 
            // tsiCustomerSearch
            // 
            this.tsiCustomerSearch.Name = "tsiCustomerSearch";
            this.tsiCustomerSearch.Size = new System.Drawing.Size(109, 22);
            this.tsiCustomerSearch.Text = "Search";
            // 
            // tsmOrders
            // 
            this.tsmOrders.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsiAddOrder,
            this.tsiSearchOrders});
            this.tsmOrders.Name = "tsmOrders";
            this.tsmOrders.Size = new System.Drawing.Size(54, 20);
            this.tsmOrders.Text = "Orders";
            // 
            // tsiAddOrder
            // 
            this.tsiAddOrder.Name = "tsiAddOrder";
            this.tsiAddOrder.Size = new System.Drawing.Size(109, 22);
            this.tsiAddOrder.Text = "Add ";
            // 
            // tsiSearchOrders
            // 
            this.tsiSearchOrders.Name = "tsiSearchOrders";
            this.tsiSearchOrders.Size = new System.Drawing.Size(109, 22);
            this.tsiSearchOrders.Text = "Search";
            // 
            // tsmReports
            // 
            this.tsmReports.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsiEmployeeBreakdown,
            this.tsiSeriesBreakdown,
            this.tsiInventoryBreakdown});
            this.tsmReports.Name = "tsmReports";
            this.tsmReports.Size = new System.Drawing.Size(59, 20);
            this.tsmReports.Text = "Reports";
            // 
            // tsiEmployeeBreakdown
            // 
            this.tsiEmployeeBreakdown.Name = "tsiEmployeeBreakdown";
            this.tsiEmployeeBreakdown.Size = new System.Drawing.Size(198, 22);
            this.tsiEmployeeBreakdown.Text = "Employee Breakdown";
            // 
            // tsiSeriesBreakdown
            // 
            this.tsiSeriesBreakdown.Name = "tsiSeriesBreakdown";
            this.tsiSeriesBreakdown.Size = new System.Drawing.Size(198, 22);
            this.tsiSeriesBreakdown.Text = "Block Series Breakdown";
            // 
            // tsiInventoryBreakdown
            // 
            this.tsiInventoryBreakdown.Name = "tsiInventoryBreakdown";
            this.tsiInventoryBreakdown.Size = new System.Drawing.Size(198, 22);
            this.tsiInventoryBreakdown.Text = "Inventory Breakdown";
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
            this.addProduct1.Margin = new System.Windows.Forms.Padding(4);
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
            this.Text = "NerdBlock";
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
        private System.Windows.Forms.ToolStripMenuItem tsiBlocks;
        private System.Windows.Forms.ToolStripMenuItem tsmInventory;
        private System.Windows.Forms.ToolStripMenuItem tsmStaff;
        private System.Windows.Forms.ToolStrip tsApplicationInfo;
        private System.Windows.Forms.ToolStripLabel tslTime;
        private System.Windows.Forms.Panel pnlMainContent;
        private System.Windows.Forms.ToolStripMenuItem tsiLogout;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem tsiExitProgram;
        private System.Windows.Forms.ToolStripMenuItem tsiInventorySearch;
        private System.Windows.Forms.ToolStripMenuItem tsiInventoryAdd;
        private System.Windows.Forms.ToolStripMenuItem tsiEmployeeSearch;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem tsiEmployeeAdd;
        private System.Windows.Forms.ToolStripMenuItem customerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsiCustomerSearch;
        private System.Windows.Forms.ToolStripMenuItem tsmOrders;
        private AddProduct addProduct1;
        private System.Windows.Forms.ToolStripMenuItem tsiLogin;
        private System.Windows.Forms.ToolStripMenuItem tsmReports;
        private System.Windows.Forms.ToolStripMenuItem tsiEmployeeBreakdown;
        private System.Windows.Forms.ToolStripMenuItem tsiSeriesBreakdown;
        private System.Windows.Forms.ToolStripMenuItem tsiInventoryBreakdown;
        private System.Windows.Forms.ToolStripMenuItem tsiInventoryLostDamaged;
        private System.Windows.Forms.ToolStripMenuItem tsiAddOrder;
        private System.Windows.Forms.ToolStripMenuItem tsiInventoryOverstock;
        private System.Windows.Forms.ToolStripMenuItem tsiBlocksGenres;
        private System.Windows.Forms.ToolStripMenuItem tsiBlocksQueries;
        private System.Windows.Forms.ToolStripMenuItem tsiBlocksAdd;
        private System.Windows.Forms.ToolStripMenuItem tsiBlocksSeries;
        private System.Windows.Forms.Timer tmrWatch;
        private System.Windows.Forms.ToolStripMenuItem tsiSearchOrders;
        private System.Windows.Forms.ToolStripMenuItem tsiChangePassword;
    }
}