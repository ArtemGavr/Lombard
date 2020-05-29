namespace ClientApp
{
    partial class MakeApplicClient
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
            this.textBoxPriceDesired = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonBack = new System.Windows.Forms.Button();
            this.buttonSendAppl = new System.Windows.Forms.Button();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.radioButtonItemName = new System.Windows.Forms.RadioButton();
            this.radioButtonProperty = new System.Windows.Forms.RadioButton();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.Description = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxPriceDesired
            // 
            this.textBoxPriceDesired.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxPriceDesired.Location = new System.Drawing.Point(57, 177);
            this.textBoxPriceDesired.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxPriceDesired.Name = "textBoxPriceDesired";
            this.textBoxPriceDesired.Size = new System.Drawing.Size(179, 26);
            this.textBoxPriceDesired.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(51, 145);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 31);
            this.label2.TabIndex = 10;
            this.label2.Text = "Desired price";
            // 
            // buttonBack
            // 
            this.buttonBack.BackColor = System.Drawing.SystemColors.Control;
            this.buttonBack.FlatAppearance.BorderSize = 0;
            this.buttonBack.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.buttonBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.buttonBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonBack.Location = new System.Drawing.Point(324, 276);
            this.buttonBack.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(84, 37);
            this.buttonBack.TabIndex = 9;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Click += new System.EventHandler(this.ButtonBack_Click);
            // 
            // buttonSendAppl
            // 
            this.buttonSendAppl.BackColor = System.Drawing.SystemColors.Control;
            this.buttonSendAppl.FlatAppearance.BorderSize = 0;
            this.buttonSendAppl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSendAppl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSendAppl.Location = new System.Drawing.Point(449, 276);
            this.buttonSendAppl.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonSendAppl.Name = "buttonSendAppl";
            this.buttonSendAppl.Size = new System.Drawing.Size(93, 37);
            this.buttonSendAppl.TabIndex = 8;
            this.buttonSendAppl.Text = "Send application";
            this.buttonSendAppl.UseVisualStyleBackColor = false;
            this.buttonSendAppl.Click += new System.EventHandler(this.ButtonSendAppl_Click);
            // 
            // textBoxName
            // 
            this.textBoxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxName.Location = new System.Drawing.Point(57, 89);
            this.textBoxName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(179, 26);
            this.textBoxName.TabIndex = 7;
            // 
            // radioButtonItemName
            // 
            this.radioButtonItemName.AutoSize = true;
            this.radioButtonItemName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButtonItemName.Location = new System.Drawing.Point(57, 26);
            this.radioButtonItemName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radioButtonItemName.Name = "radioButtonItemName";
            this.radioButtonItemName.Size = new System.Drawing.Size(138, 30);
            this.radioButtonItemName.TabIndex = 12;
            this.radioButtonItemName.TabStop = true;
            this.radioButtonItemName.Text = "Item Name";
            this.radioButtonItemName.UseVisualStyleBackColor = true;
            // 
            // radioButtonProperty
            // 
            this.radioButtonProperty.AutoSize = true;
            this.radioButtonProperty.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButtonProperty.Location = new System.Drawing.Point(57, 58);
            this.radioButtonProperty.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radioButtonProperty.Name = "radioButtonProperty";
            this.radioButtonProperty.Size = new System.Drawing.Size(183, 30);
            this.radioButtonProperty.TabIndex = 13;
            this.radioButtonProperty.TabStop = true;
            this.radioButtonProperty.Text = "Property adress";
            this.radioButtonProperty.UseVisualStyleBackColor = true;
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxDescription.Location = new System.Drawing.Point(57, 264);
            this.textBoxDescription.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxDescription.Multiline = true;
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(179, 51);
            this.textBoxDescription.TabIndex = 15;
            // 
            // Description
            // 
            this.Description.AutoSize = true;
            this.Description.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Description.Location = new System.Drawing.Point(51, 232);
            this.Description.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Description.Name = "Description";
            this.Description.Size = new System.Drawing.Size(151, 31);
            this.Description.TabIndex = 14;
            this.Description.Text = "Description";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(319, 16);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 31);
            this.label3.TabIndex = 32;
            this.label3.Text = "Image";
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox.Location = new System.Drawing.Point(324, 62);
            this.pictureBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(207, 157);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 31;
            this.pictureBox.TabStop = false;
            this.pictureBox.Click += new System.EventHandler(this.PictureBox_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // MakeApplicClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(578, 358);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.textBoxDescription);
            this.Controls.Add(this.Description);
            this.Controls.Add(this.radioButtonProperty);
            this.Controls.Add(this.radioButtonItemName);
            this.Controls.Add(this.textBoxPriceDesired);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonSendAppl);
            this.Controls.Add(this.textBoxName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "MakeApplicClient";
            this.Text = "Applic";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ApplicClient_FormClosing);
            this.Load += new System.EventHandler(this.Applic_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxPriceDesired;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button buttonSendAppl;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.RadioButton radioButtonItemName;
        private System.Windows.Forms.RadioButton radioButtonProperty;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.Label Description;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}