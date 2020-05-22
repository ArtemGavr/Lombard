﻿namespace ClientApp
{
    partial class ApplicClient
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
            this.SuspendLayout();
            // 
            // textBoxPriceDesired
            // 
            this.textBoxPriceDesired.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxPriceDesired.Location = new System.Drawing.Point(477, 100);
            this.textBoxPriceDesired.Name = "textBoxPriceDesired";
            this.textBoxPriceDesired.Size = new System.Drawing.Size(153, 35);
            this.textBoxPriceDesired.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(472, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 29);
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
            this.buttonBack.Location = new System.Drawing.Point(82, 325);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(122, 57);
            this.buttonBack.TabIndex = 9;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // buttonSendAppl
            // 
            this.buttonSendAppl.BackColor = System.Drawing.SystemColors.Control;
            this.buttonSendAppl.FlatAppearance.BorderSize = 0;
            this.buttonSendAppl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSendAppl.Location = new System.Drawing.Point(597, 325);
            this.buttonSendAppl.Name = "buttonSendAppl";
            this.buttonSendAppl.Size = new System.Drawing.Size(122, 57);
            this.buttonSendAppl.TabIndex = 8;
            this.buttonSendAppl.Text = "Send application";
            this.buttonSendAppl.UseVisualStyleBackColor = false;
            this.buttonSendAppl.Click += new System.EventHandler(this.buttonSendAppl_Click);
            // 
            // textBoxName
            // 
            this.textBoxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxName.Location = new System.Drawing.Point(242, 100);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(153, 35);
            this.textBoxName.TabIndex = 7;
            // 
            // radioButtonItemName
            // 
            this.radioButtonItemName.AutoSize = true;
            this.radioButtonItemName.Location = new System.Drawing.Point(242, 40);
            this.radioButtonItemName.Name = "radioButtonItemName";
            this.radioButtonItemName.Size = new System.Drawing.Size(112, 24);
            this.radioButtonItemName.TabIndex = 12;
            this.radioButtonItemName.TabStop = true;
            this.radioButtonItemName.Text = "Item Name";
            this.radioButtonItemName.UseVisualStyleBackColor = true;
//            this.radioButtonItemName.CheckedChanged += new System.EventHandler(this.radioButtonItemName_CheckedChanged);
            // 
            // radioButtonProperty
            // 
            this.radioButtonProperty.AutoSize = true;
            this.radioButtonProperty.Location = new System.Drawing.Point(242, 68);
            this.radioButtonProperty.Name = "radioButtonProperty";
            this.radioButtonProperty.Size = new System.Drawing.Size(145, 24);
            this.radioButtonProperty.TabIndex = 13;
            this.radioButtonProperty.TabStop = true;
            this.radioButtonProperty.Text = "Property adress";
            this.radioButtonProperty.UseVisualStyleBackColor = true;
            //this.radioButtonProperty.CheckedChanged += new System.EventHandler(this.radioButtonProperty_CheckedChanged);
            // 
            // ApplicClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.radioButtonProperty);
            this.Controls.Add(this.radioButtonItemName);
            this.Controls.Add(this.textBoxPriceDesired);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonSendAppl);
            this.Controls.Add(this.textBoxName);
            this.Name = "ApplicClient";
            this.Text = "Applic";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ApplicClient_FormClosing);
            this.Load += new System.EventHandler(this.Applic_Load);
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
    }
}