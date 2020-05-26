namespace ClientApp
{
    partial class ClientMain
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
            this.buttonVerify = new System.Windows.Forms.Button();
            this.dataGridViewProducts = new System.Windows.Forms.DataGridView();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buttonPurchase = new System.Windows.Forms.Button();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imageDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giverNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.storeDaysDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonApplications
            // 
            this.buttonApplications.Location = new System.Drawing.Point(960, 445);
            this.buttonApplications.Name = "buttonApplications";
            this.buttonApplications.Size = new System.Drawing.Size(121, 58);
            this.buttonApplications.TabIndex = 0;
            this.buttonApplications.Text = "Send applications";
            this.buttonApplications.UseVisualStyleBackColor = true;
            this.buttonApplications.Click += new System.EventHandler(this.ButtonApplications_Click);
            // 
            // buttonVerify
            // 
            this.buttonVerify.Location = new System.Drawing.Point(960, 530);
            this.buttonVerify.Name = "buttonVerify";
            this.buttonVerify.Size = new System.Drawing.Size(121, 52);
            this.buttonVerify.TabIndex = 1;
            this.buttonVerify.Text = "Verify applics";
            this.buttonVerify.UseVisualStyleBackColor = true;
            this.buttonVerify.Click += new System.EventHandler(this.ButtonVerify_Click);
            // 
            // dataGridViewProducts
            // 
            this.dataGridViewProducts.AllowUserToAddRows = false;
            this.dataGridViewProducts.AutoGenerateColumns = false;
            this.dataGridViewProducts.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridViewProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProducts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.imageDataGridViewImageColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.typeDataGridViewTextBoxColumn,
            this.giverNameDataGridViewTextBoxColumn,
            this.dateTimeDataGridViewTextBoxColumn,
            this.storeDaysDataGridViewTextBoxColumn});
            this.dataGridViewProducts.DataSource = this.productBindingSource;
            this.dataGridViewProducts.Location = new System.Drawing.Point(1, 2);
            this.dataGridViewProducts.Name = "dataGridViewProducts";
            this.dataGridViewProducts.ReadOnly = true;
            this.dataGridViewProducts.RowHeadersWidth = 62;
            this.dataGridViewProducts.RowTemplate.Height = 28;
            this.dataGridViewProducts.Size = new System.Drawing.Size(1094, 436);
            this.dataGridViewProducts.TabIndex = 2;
            this.dataGridViewProducts.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.DataGridViewProducts_DataBindingComplete);
            this.dataGridViewProducts.BindingContextChanged += new System.EventHandler(this.DataGridViewProducts_BindingContextChanged);
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataSource = typeof(Lombard_Project.UserClasses.Product);
            // 
            // buttonPurchase
            // 
            this.buttonPurchase.Location = new System.Drawing.Point(22, 484);
            this.buttonPurchase.Name = "buttonPurchase";
            this.buttonPurchase.Size = new System.Drawing.Size(121, 52);
            this.buttonPurchase.TabIndex = 3;
            this.buttonPurchase.Text = "Purchase";
            this.buttonPurchase.UseVisualStyleBackColor = true;
            this.buttonPurchase.Click += new System.EventHandler(this.ButtonPurchase_Click);
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn.Width = 150;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.ReadOnly = true;
            this.priceDataGridViewTextBoxColumn.Width = 150;
            // 
            // imageDataGridViewImageColumn
            // 
            this.imageDataGridViewImageColumn.DataPropertyName = "Image";
            this.imageDataGridViewImageColumn.HeaderText = "Image";
            this.imageDataGridViewImageColumn.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.imageDataGridViewImageColumn.MinimumWidth = 8;
            this.imageDataGridViewImageColumn.Name = "imageDataGridViewImageColumn";
            this.imageDataGridViewImageColumn.ReadOnly = true;
            this.imageDataGridViewImageColumn.Width = 150;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.ReadOnly = true;
            this.descriptionDataGridViewTextBoxColumn.Width = 150;
            // 
            // typeDataGridViewTextBoxColumn
            // 
            this.typeDataGridViewTextBoxColumn.DataPropertyName = "Type";
            this.typeDataGridViewTextBoxColumn.HeaderText = "Type";
            this.typeDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
            this.typeDataGridViewTextBoxColumn.ReadOnly = true;
            this.typeDataGridViewTextBoxColumn.Width = 150;
            // 
            // giverNameDataGridViewTextBoxColumn
            // 
            this.giverNameDataGridViewTextBoxColumn.DataPropertyName = "GiverName";
            this.giverNameDataGridViewTextBoxColumn.HeaderText = "GiverName";
            this.giverNameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.giverNameDataGridViewTextBoxColumn.Name = "giverNameDataGridViewTextBoxColumn";
            this.giverNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.giverNameDataGridViewTextBoxColumn.Width = 150;
            // 
            // dateTimeDataGridViewTextBoxColumn
            // 
            this.dateTimeDataGridViewTextBoxColumn.DataPropertyName = "DateTime";
            this.dateTimeDataGridViewTextBoxColumn.HeaderText = "DateTime";
            this.dateTimeDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.dateTimeDataGridViewTextBoxColumn.Name = "dateTimeDataGridViewTextBoxColumn";
            this.dateTimeDataGridViewTextBoxColumn.ReadOnly = true;
            this.dateTimeDataGridViewTextBoxColumn.Width = 150;
            // 
            // storeDaysDataGridViewTextBoxColumn
            // 
            this.storeDaysDataGridViewTextBoxColumn.DataPropertyName = "StoreDays";
            this.storeDaysDataGridViewTextBoxColumn.HeaderText = "StoreDays";
            this.storeDaysDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.storeDaysDataGridViewTextBoxColumn.Name = "storeDaysDataGridViewTextBoxColumn";
            this.storeDaysDataGridViewTextBoxColumn.ReadOnly = true;
            this.storeDaysDataGridViewTextBoxColumn.Width = 150;
            // 
            // ClientMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1093, 585);
            this.Controls.Add(this.buttonPurchase);
            this.Controls.Add(this.dataGridViewProducts);
            this.Controls.Add(this.buttonVerify);
            this.Controls.Add(this.buttonApplications);
            this.Name = "ClientMain";
            this.Text = "ClientMain";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ClientMain_FormClosing);
            this.Load += new System.EventHandler(this.ClientMain_Load);
            this.VisibleChanged += new System.EventHandler(this.ClientMain_VisibleChanged);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonApplications;
        private System.Windows.Forms.Button buttonVerify;
        private System.Windows.Forms.DataGridView dataGridViewProducts;
        private System.Windows.Forms.BindingSource productBindingSource;
        private System.Windows.Forms.Button buttonPurchase;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn imageDataGridViewImageColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn giverNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn storeDaysDataGridViewTextBoxColumn;
    }
}