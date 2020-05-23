namespace AdminApp
{
    partial class EditionForm
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
            this.textBoxProductType = new System.Windows.Forms.TextBox();
            this.ProductType = new System.Windows.Forms.Label();
            this.textBoxClientName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.labelClientName = new System.Windows.Forms.Label();
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
            this.buttonSendAppl.FlatAppearance.BorderSize = 0;
            this.buttonSendAppl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSendAppl.Location = new System.Drawing.Point(592, 323);
            this.buttonSendAppl.Name = "buttonSendAppl";
            this.buttonSendAppl.Size = new System.Drawing.Size(122, 57);
            this.buttonSendAppl.TabIndex = 2;
            this.buttonSendAppl.Text = "Send application";
            this.buttonSendAppl.UseVisualStyleBackColor = false;
            this.buttonSendAppl.Click += new System.EventHandler(this.buttonSendAppl_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Control;
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
            // textBoxProductType
            // 
            this.textBoxProductType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxProductType.Location = new System.Drawing.Point(114, 178);
            this.textBoxProductType.Name = "textBoxProductType";
            this.textBoxProductType.Size = new System.Drawing.Size(153, 35);
            this.textBoxProductType.TabIndex = 19;
            // 
            // ProductType
            // 
            this.ProductType.AutoSize = true;
            this.ProductType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ProductType.Location = new System.Drawing.Point(121, 146);
            this.ProductType.Name = "ProductType";
            this.ProductType.Size = new System.Drawing.Size(157, 29);
            this.ProductType.TabIndex = 18;
            this.ProductType.Text = "Product Type";
            // 
            // textBoxClientName
            // 
            this.textBoxClientName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxClientName.Location = new System.Drawing.Point(114, 91);
            this.textBoxClientName.Name = "textBoxClientName";
            this.textBoxClientName.Size = new System.Drawing.Size(153, 35);
            this.textBoxClientName.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(121, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 29);
            this.label4.TabIndex = 20;
            this.label4.Text = "Client Name";
            // 
            // labelClientName
            // 
            this.labelClientName.AutoSize = true;
            this.labelClientName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelClientName.Location = new System.Drawing.Point(285, 97);
            this.labelClientName.Name = "labelClientName";
            this.labelClientName.Size = new System.Drawing.Size(146, 29);
            this.labelClientName.TabIndex = 22;
            this.labelClientName.Text = "Client Name";
            // 
            // EditionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelClientName);
            this.Controls.Add(this.textBoxClientName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxProductType);
            this.Controls.Add(this.ProductType);
            this.Controls.Add(this.textBoxDescription);
            this.Controls.Add(this.Description);
            this.Controls.Add(this.textBoxPrice);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonSendAppl);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.label1);
            this.Name = "EditionForm";
            this.Text = "Edit";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EditionForm_FormClosing);
            this.Load += new System.EventHandler(this.EditionForm_Load);
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
        private System.Windows.Forms.TextBox textBoxProductType;
        private System.Windows.Forms.Label ProductType;
        private System.Windows.Forms.TextBox textBoxClientName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelClientName;
    }
}