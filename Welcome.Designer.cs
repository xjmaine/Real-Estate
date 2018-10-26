namespace WindowsFormsApp1
{
    partial class Welcome
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ownerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.builderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.propertyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.matchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.UtilitiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lOGOUTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblclient = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.clientSearchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agentSearchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.builderSearchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.propertySearchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.propertyClientMatchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.searchToolStripMenuItem,
            this.matchToolStripMenuItem,
            this.reportToolStripMenuItem,
            this.UtilitiesToolStripMenuItem,
            this.lOGOUTToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientToolStripMenuItem,
            this.ownerToolStripMenuItem,
            this.agentToolStripMenuItem,
            this.builderToolStripMenuItem,
            this.propertyToolStripMenuItem});
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.newToolStripMenuItem.Text = "New";
            // 
            // clientToolStripMenuItem
            // 
            this.clientToolStripMenuItem.Name = "clientToolStripMenuItem";
            this.clientToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.clientToolStripMenuItem.Text = "Client";
            this.clientToolStripMenuItem.Click += new System.EventHandler(this.clientToolStripMenuItem_Click);
            // 
            // ownerToolStripMenuItem
            // 
            this.ownerToolStripMenuItem.Name = "ownerToolStripMenuItem";
            this.ownerToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ownerToolStripMenuItem.Text = "Owner";
            this.ownerToolStripMenuItem.Click += new System.EventHandler(this.ownerToolStripMenuItem_Click);
            // 
            // agentToolStripMenuItem
            // 
            this.agentToolStripMenuItem.Name = "agentToolStripMenuItem";
            this.agentToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.agentToolStripMenuItem.Text = "Agent";
            this.agentToolStripMenuItem.Click += new System.EventHandler(this.agentToolStripMenuItem_Click);
            // 
            // builderToolStripMenuItem
            // 
            this.builderToolStripMenuItem.Name = "builderToolStripMenuItem";
            this.builderToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.builderToolStripMenuItem.Text = "Builder";
            this.builderToolStripMenuItem.Click += new System.EventHandler(this.builderToolStripMenuItem_Click);
            // 
            // propertyToolStripMenuItem
            // 
            this.propertyToolStripMenuItem.Name = "propertyToolStripMenuItem";
            this.propertyToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.propertyToolStripMenuItem.Text = "Property";
            this.propertyToolStripMenuItem.Click += new System.EventHandler(this.propertyToolStripMenuItem_Click);
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientSearchToolStripMenuItem,
            this.toolStripMenuItem1,
            this.agentSearchToolStripMenuItem,
            this.builderSearchToolStripMenuItem,
            this.propertySearchToolStripMenuItem});
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.searchToolStripMenuItem.Text = "Search";
            // 
            // matchToolStripMenuItem
            // 
            this.matchToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.propertyClientMatchToolStripMenuItem});
            this.matchToolStripMenuItem.Name = "matchToolStripMenuItem";
            this.matchToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.matchToolStripMenuItem.Text = "Match";
            // 
            // reportToolStripMenuItem
            // 
            this.reportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientReportToolStripMenuItem});
            this.reportToolStripMenuItem.Name = "reportToolStripMenuItem";
            this.reportToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.reportToolStripMenuItem.Text = "Report";
            // 
            // UtilitiesToolStripMenuItem
            // 
            this.UtilitiesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newUserToolStripMenuItem});
            this.UtilitiesToolStripMenuItem.Name = "UtilitiesToolStripMenuItem";
            this.UtilitiesToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.UtilitiesToolStripMenuItem.Text = "Utilities";
            // 
            // lOGOUTToolStripMenuItem
            // 
            this.lOGOUTToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lOGOUTToolStripMenuItem.ForeColor = System.Drawing.Color.Red;
            this.lOGOUTToolStripMenuItem.Name = "lOGOUTToolStripMenuItem";
            this.lOGOUTToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.lOGOUTToolStripMenuItem.Text = "Sign-Out";
            this.lOGOUTToolStripMenuItem.Click += new System.EventHandler(this.lOGOUTToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(576, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Summary:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(627, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Client Summary";
            // 
            // lblclient
            // 
            this.lblclient.AutoSize = true;
            this.lblclient.Location = new System.Drawing.Point(712, 0);
            this.lblclient.Name = "lblclient";
            this.lblclient.Size = new System.Drawing.Size(13, 13);
            this.lblclient.TabIndex = 3;
            this.lblclient.Text = "0";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // clientSearchToolStripMenuItem
            // 
            this.clientSearchToolStripMenuItem.Name = "clientSearchToolStripMenuItem";
            this.clientSearchToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.clientSearchToolStripMenuItem.Text = "Client Search";
            this.clientSearchToolStripMenuItem.Click += new System.EventHandler(this.clientSearchToolStripMenuItem_Click);
            // 
            // agentSearchToolStripMenuItem
            // 
            this.agentSearchToolStripMenuItem.Name = "agentSearchToolStripMenuItem";
            this.agentSearchToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.agentSearchToolStripMenuItem.Text = "Agent Search";
            this.agentSearchToolStripMenuItem.Click += new System.EventHandler(this.agentSearchToolStripMenuItem_Click);
            // 
            // builderSearchToolStripMenuItem
            // 
            this.builderSearchToolStripMenuItem.Name = "builderSearchToolStripMenuItem";
            this.builderSearchToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.builderSearchToolStripMenuItem.Text = "Builder Search";
            this.builderSearchToolStripMenuItem.Click += new System.EventHandler(this.builderSearchToolStripMenuItem_Click);
            // 
            // propertySearchToolStripMenuItem
            // 
            this.propertySearchToolStripMenuItem.Name = "propertySearchToolStripMenuItem";
            this.propertySearchToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.propertySearchToolStripMenuItem.Text = "Property Search";
            this.propertySearchToolStripMenuItem.Click += new System.EventHandler(this.propertySearchToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem1.Text = "Owner Search";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // propertyClientMatchToolStripMenuItem
            // 
            this.propertyClientMatchToolStripMenuItem.Name = "propertyClientMatchToolStripMenuItem";
            this.propertyClientMatchToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.propertyClientMatchToolStripMenuItem.Text = "Property Client Match";
            this.propertyClientMatchToolStripMenuItem.Click += new System.EventHandler(this.propertyClientMatchToolStripMenuItem_Click);
            // 
            // clientReportToolStripMenuItem
            // 
            this.clientReportToolStripMenuItem.Name = "clientReportToolStripMenuItem";
            this.clientReportToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.clientReportToolStripMenuItem.Text = "Client Report";
            this.clientReportToolStripMenuItem.Click += new System.EventHandler(this.clientReportToolStripMenuItem_Click);
            // 
            // newUserToolStripMenuItem
            // 
            this.newUserToolStripMenuItem.Name = "newUserToolStripMenuItem";
            this.newUserToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.newUserToolStripMenuItem.Text = "New User";
            this.newUserToolStripMenuItem.Click += new System.EventHandler(this.newUserToolStripMenuItem_Click);
            // 
            // Welcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.lblclient);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Welcome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Welcome";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ownerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem builderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem propertyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem matchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem UtilitiesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lOGOUTToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblclient;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolStripMenuItem clientSearchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agentSearchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem builderSearchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem propertySearchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem propertyClientMatchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newUserToolStripMenuItem;
    }
}