namespace AdminApp
{
    partial class EditApplicAdmin
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
            this.listBoxType = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.labelClientName = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.DaysToStore = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DaysToStore)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(202, 8);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Product name";
            // 
            // textBoxName
            // 
            this.textBoxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxName.Location = new System.Drawing.Point(207, 47);
            this.textBoxName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(189, 38);
            this.textBoxName.TabIndex = 1;
            // 
            // buttonSendAppl
            // 
            this.buttonSendAppl.BackColor = System.Drawing.SystemColors.Control;
            this.buttonSendAppl.FlatAppearance.BorderSize = 0;
            this.buttonSendAppl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSendAppl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSendAppl.Location = new System.Drawing.Point(569, 279);
            this.buttonSendAppl.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonSendAppl.Name = "buttonSendAppl";
            this.buttonSendAppl.Size = new System.Drawing.Size(104, 42);
            this.buttonSendAppl.TabIndex = 2;
            this.buttonSendAppl.Text = "Send application to client";
            this.buttonSendAppl.UseVisualStyleBackColor = false;
            this.buttonSendAppl.Click += new System.EventHandler(this.ButtonSendAppl_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Control;
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(453, 279);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 42);
            this.button1.TabIndex = 3;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxPrice.Location = new System.Drawing.Point(207, 149);
            this.textBoxPrice.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(189, 38);
            this.textBoxPrice.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(202, 107);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 31);
            this.label2.TabIndex = 4;
            this.label2.Text = "Desired price";
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxDescription.Location = new System.Drawing.Point(207, 257);
            this.textBoxDescription.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxDescription.Multiline = true;
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(189, 73);
            this.textBoxDescription.TabIndex = 17;
            // 
            // Description
            // 
            this.Description.AutoSize = true;
            this.Description.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Description.Location = new System.Drawing.Point(202, 213);
            this.Description.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Description.Name = "Description";
            this.Description.Size = new System.Drawing.Size(151, 31);
            this.Description.TabIndex = 16;
            this.Description.Text = "Description";
            // 
            // listBoxType
            // 
            this.listBoxType.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBoxType.FormattingEnabled = true;
            this.listBoxType.ItemHeight = 31;
            this.listBoxType.Items.AddRange(new object[] {
            "Item",
            "Property"});
            this.listBoxType.Location = new System.Drawing.Point(13, 147);
            this.listBoxType.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listBoxType.Name = "listBoxType";
            this.listBoxType.Size = new System.Drawing.Size(85, 35);
            this.listBoxType.TabIndex = 31;
            this.listBoxType.SelectedIndexChanged += new System.EventHandler(this.ListBoxType_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(447, 8);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 31);
            this.label3.TabIndex = 30;
            this.label3.Text = "Image";
            // 
            // labelClientName
            // 
            this.labelClientName.AutoSize = true;
            this.labelClientName.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.labelClientName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelClientName.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelClientName.Location = new System.Drawing.Point(7, 45);
            this.labelClientName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelClientName.Name = "labelClientName";
            this.labelClientName.Size = new System.Drawing.Size(165, 33);
            this.labelClientName.TabIndex = 28;
            this.labelClientName.Text = "Client Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(8, 6);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(163, 31);
            this.label6.TabIndex = 27;
            this.label6.Text = "Client Name";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(8, 105);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(176, 31);
            this.label7.TabIndex = 26;
            this.label7.Text = "Product Type";
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox.Location = new System.Drawing.Point(453, 47);
            this.pictureBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(221, 185);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 29;
            this.pictureBox.TabStop = false;
            this.pictureBox.Click += new System.EventHandler(this.PictureBox_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // DaysToStore
            // 
            this.DaysToStore.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DaysToStore.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.DaysToStore.Location = new System.Drawing.Point(13, 248);
            this.DaysToStore.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DaysToStore.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.DaysToStore.Minimum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.DaysToStore.Name = "DaysToStore";
            this.DaysToStore.Size = new System.Drawing.Size(83, 38);
            this.DaysToStore.TabIndex = 32;
            this.DaysToStore.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(8, 211);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(175, 31);
            this.label4.TabIndex = 33;
            this.label4.Text = "Days to store";
            // 
            // EditApplicAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(696, 362);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.DaysToStore);
            this.Controls.Add(this.listBoxType);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.labelClientName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxDescription);
            this.Controls.Add(this.Description);
            this.Controls.Add(this.textBoxPrice);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonSendAppl);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "EditApplicAdmin";
            this.Text = "Edit";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EditionForm_FormClosing);
            this.Load += new System.EventHandler(this.EditionForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DaysToStore)).EndInit();
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
        private System.Windows.Forms.ListBox listBoxType;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Label labelClientName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.NumericUpDown DaysToStore;
        private System.Windows.Forms.Label label4;
    }
}