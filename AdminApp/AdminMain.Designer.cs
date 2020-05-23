namespace AdminApp
{
    partial class AdminMain
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
            this.buttonApplications = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jjToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1products = new System.Windows.Forms.TabPage();
            this.tabPageApplications = new System.Windows.Forms.TabPage();
            this.dataGridViewApplics = new System.Windows.Forms.DataGridView();
            this.prodDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giverDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.myApplicationBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPageApplications.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewApplics)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myApplicationBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonApplications
            // 
            this.buttonApplications.Location = new System.Drawing.Point(1073, 36);
            this.buttonApplications.Name = "buttonApplications";
            this.buttonApplications.Size = new System.Drawing.Size(50, 52);
            this.buttonApplications.TabIndex = 0;
            this.buttonApplications.Text = "Applications";
            this.buttonApplications.UseVisualStyleBackColor = true;
            this.buttonApplications.Click += new System.EventHandler(this.buttonApplications_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(1027, 619);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(96, 58);
            this.buttonExit.TabIndex = 1;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.jjToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip1.Size = new System.Drawing.Size(1123, 36);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem1,
            this.openToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(54, 30);
            this.saveToolStripMenuItem.Text = "File";
            // 
            // saveToolStripMenuItem1
            // 
            this.saveToolStripMenuItem1.Name = "saveToolStripMenuItem1";
            this.saveToolStripMenuItem1.Size = new System.Drawing.Size(158, 34);
            this.saveToolStripMenuItem1.Text = "Save";
            this.saveToolStripMenuItem1.Click += new System.EventHandler(this.saveToolStripMenuItem1_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(158, 34);
            this.openToolStripMenuItem.Text = "Open";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(155, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(158, 34);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // jjToolStripMenuItem
            // 
            this.jjToolStripMenuItem.Name = "jjToolStripMenuItem";
            this.jjToolStripMenuItem.Size = new System.Drawing.Size(65, 30);
            this.jjToolStripMenuItem.Text = "Help";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1products);
            this.tabControl1.Controls.Add(this.tabPageApplications);
            this.tabControl1.Location = new System.Drawing.Point(12, 36);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1009, 641);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage1products
            // 
            this.tabPage1products.Location = new System.Drawing.Point(4, 29);
            this.tabPage1products.Name = "tabPage1products";
            this.tabPage1products.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1products.Size = new System.Drawing.Size(1001, 608);
            this.tabPage1products.TabIndex = 0;
            this.tabPage1products.Text = "Products";
            this.tabPage1products.UseVisualStyleBackColor = true;
            // 
            // tabPageApplications
            // 
            this.tabPageApplications.Controls.Add(this.dataGridViewApplics);
            this.tabPageApplications.Location = new System.Drawing.Point(4, 29);
            this.tabPageApplications.Name = "tabPageApplications";
            this.tabPageApplications.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageApplications.Size = new System.Drawing.Size(1001, 608);
            this.tabPageApplications.TabIndex = 1;
            this.tabPageApplications.Text = "Applications";
            this.tabPageApplications.UseVisualStyleBackColor = true;
            // 
            // dataGridViewApplics
            // 
            this.dataGridViewApplics.AllowUserToOrderColumns = true;
            this.dataGridViewApplics.AutoGenerateColumns = false;
            this.dataGridViewApplics.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewApplics.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.prodDataGridViewTextBoxColumn,
            this.giverDataGridViewTextBoxColumn});
            this.dataGridViewApplics.DataSource = this.myApplicationBindingSource1;
            this.dataGridViewApplics.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewApplics.Name = "dataGridViewApplics";
            this.dataGridViewApplics.RowHeadersWidth = 62;
            this.dataGridViewApplics.RowTemplate.Height = 28;
            this.dataGridViewApplics.Size = new System.Drawing.Size(998, 605);
            this.dataGridViewApplics.TabIndex = 0;
            this.dataGridViewApplics.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewApplics_CellContentDoubleClick);
            this.dataGridViewApplics.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewApplics_CellContentDoubleClick);
            // 
            // prodDataGridViewTextBoxColumn
            // 
            this.prodDataGridViewTextBoxColumn.DataPropertyName = "Prod";
            this.prodDataGridViewTextBoxColumn.HeaderText = "Prod";
            this.prodDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.prodDataGridViewTextBoxColumn.Name = "prodDataGridViewTextBoxColumn";
            this.prodDataGridViewTextBoxColumn.Width = 150;
            // 
            // giverDataGridViewTextBoxColumn
            // 
            this.giverDataGridViewTextBoxColumn.DataPropertyName = "Giver";
            this.giverDataGridViewTextBoxColumn.HeaderText = "Giver";
            this.giverDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.giverDataGridViewTextBoxColumn.Name = "giverDataGridViewTextBoxColumn";
            this.giverDataGridViewTextBoxColumn.Width = 150;
            // 
            // myApplicationBindingSource1
            // 
            this.myApplicationBindingSource1.DataSource = typeof(Lombard_Project.UserClasses.MyApplication);
            // 
            // AdminMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1123, 680);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonApplications);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "AdminMain";
            this.Text = "AdminMain";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AdminMain_FormClosing);
            this.Load += new System.EventHandler(this.AdminMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPageApplications.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewApplics)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myApplicationBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonApplications;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem jjToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1products;
        private System.Windows.Forms.TabPage tabPageApplications;
        private System.Windows.Forms.DataGridView dataGridViewApplics;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn giverDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource myApplicationBindingSource1;
    }
}