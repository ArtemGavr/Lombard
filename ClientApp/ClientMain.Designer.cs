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
            this.buttonApplications = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonApplications
            // 
            this.buttonApplications.Location = new System.Drawing.Point(667, 24);
            this.buttonApplications.Name = "buttonApplications";
            this.buttonApplications.Size = new System.Drawing.Size(121, 47);
            this.buttonApplications.TabIndex = 0;
            this.buttonApplications.Text = "Applications";
            this.buttonApplications.UseVisualStyleBackColor = true;
            this.buttonApplications.Click += new System.EventHandler(this.buttonApplications_Click);
            // 
            // ClientMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonApplications);
            this.Name = "ClientMain";
            this.Text = "ClientMain";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ClientMain_FormClosing);
            this.Load += new System.EventHandler(this.ClientMain_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonApplications;
    }
}