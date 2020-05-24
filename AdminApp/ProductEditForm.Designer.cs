namespace AdminApp
{
    partial class ProductEditForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.buttonSendAppl = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.Description = new System.Windows.Forms.Label();
            this.ProductType = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelClientName = new System.Windows.Forms.Label();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label3 = new System.Windows.Forms.Label();
            this.listBoxType = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(523, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // textBoxName
            // 
            this.textBoxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxName.Location = new System.Drawing.Point(490, 70);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(153, 35);
            this.textBoxName.TabIndex = 1;
            // 
            // buttonSendAppl
            // 
            this.buttonSendAppl.BackColor = System.Drawing.SystemColors.Control;
            this.buttonSendAppl.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonSendAppl.FlatAppearance.BorderSize = 0;
            this.buttonSendAppl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSendAppl.Location = new System.Drawing.Point(628, 337);
            this.buttonSendAppl.Name = "buttonSendAppl";
            this.buttonSendAppl.Size = new System.Drawing.Size(86, 43);
            this.buttonSendAppl.TabIndex = 2;
            this.buttonSendAppl.Text = "Edit";
            this.buttonSendAppl.UseVisualStyleBackColor = false;
            this.buttonSendAppl.Click += new System.EventHandler(this.buttonSendAppl_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Control;
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(77, 323);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 57);
            this.button1.TabIndex = 3;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxPrice.Location = new System.Drawing.Point(490, 163);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(153, 35);
            this.textBoxPrice.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(494, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 29);
            this.label2.TabIndex = 4;
            this.label2.Text = "Desired price";
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxDescription.Location = new System.Drawing.Point(490, 248);
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(153, 35);
            this.textBoxDescription.TabIndex = 17;
            // 
            // Description
            // 
            this.Description.AutoSize = true;
            this.Description.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Description.Location = new System.Drawing.Point(497, 216);
            this.Description.Name = "Description";
            this.Description.Size = new System.Drawing.Size(135, 29);
            this.Description.TabIndex = 16;
            this.Description.Text = "Description";
            // 
            // ProductType
            // 
            this.ProductType.AutoSize = true;
            this.ProductType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ProductType.Location = new System.Drawing.Point(238, 43);
            this.ProductType.Name = "ProductType";
            this.ProductType.Size = new System.Drawing.Size(157, 29);
            this.ProductType.TabIndex = 18;
            this.ProductType.Text = "Product Type";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(6, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 29);
            this.label4.TabIndex = 20;
            this.label4.Text = "Client Name";
            // 
            // labelClientName
            // 
            this.labelClientName.AutoSize = true;
            this.labelClientName.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.labelClientName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelClientName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelClientName.Location = new System.Drawing.Point(6, 38);
            this.labelClientName.Name = "labelClientName";
            this.labelClientName.Size = new System.Drawing.Size(148, 31);
            this.labelClientName.TabIndex = 22;
            this.labelClientName.Text = "Client Name";
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pictureBox.Location = new System.Drawing.Point(219, 163);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(232, 159);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 23;
            this.pictureBox.TabStop = false;
            this.pictureBox.Click += new System.EventHandler(this.pictureBox_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(238, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 29);
            this.label3.TabIndex = 24;
            this.label3.Text = "Image";
            // 
            // listBoxType
            // 
            this.listBoxType.FormattingEnabled = true;
            this.listBoxType.ItemHeight = 20;
            this.listBoxType.Items.AddRange(new object[] {
            "Item",
            "Property"});
            this.listBoxType.Location = new System.Drawing.Point(243, 70);
            this.listBoxType.Name = "listBoxType";
            this.listBoxType.Size = new System.Drawing.Size(83, 44);
            this.listBoxType.TabIndex = 25;
            this.listBoxType.SelectedIndexChanged += new System.EventHandler(this.listBoxType_SelectedIndexChanged);
            // 
            // ProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBoxType);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.labelClientName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ProductType);
            this.Controls.Add(this.textBoxDescription);
            this.Controls.Add(this.Description);
            this.Controls.Add(this.textBoxPrice);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonSendAppl);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.label1);
            this.Name = "ProductForm";
            this.Text = "Edit";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ProductForm_FormClosing);
            this.Load += new System.EventHandler(this.ProductForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Button buttonSendAppl;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.Label Description;
        private System.Windows.Forms.Label ProductType;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelClientName;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listBoxType;
    }
}