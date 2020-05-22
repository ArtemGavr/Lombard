namespace ClientApp
{
    partial class Register
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
            this.buttonCancel = new System.Windows.Forms.Button();
            this.IDbox = new System.Windows.Forms.TextBox();
            this.buttonRegister = new System.Windows.Forms.Button();
            this.RegPassword = new System.Windows.Forms.TextBox();
            this.RegName = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.CloseButton = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelLogin = new System.Windows.Forms.Label();
            this.labelID = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.RegPassReenter = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonCancel
            // 
            this.buttonCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(230)))), ((int)(((byte)(234)))));
            this.buttonCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCancel.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.buttonCancel.FlatAppearance.BorderSize = 0;
            this.buttonCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.buttonCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.buttonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancel.Font = new System.Drawing.Font("Arial Narrow", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCancel.Location = new System.Drawing.Point(78, 404);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(141, 68);
            this.buttonCancel.TabIndex = 23;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = false;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // IDbox
            // 
            this.IDbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IDbox.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.IDbox.Location = new System.Drawing.Point(153, 328);
            this.IDbox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.IDbox.Multiline = true;
            this.IDbox.Name = "IDbox";
            this.IDbox.Size = new System.Drawing.Size(318, 33);
            this.IDbox.TabIndex = 22;
            // 
            // buttonRegister
            // 
            this.buttonRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(230)))), ((int)(((byte)(234)))));
            this.buttonRegister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonRegister.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.buttonRegister.FlatAppearance.BorderSize = 0;
            this.buttonRegister.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.buttonRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRegister.Font = new System.Drawing.Font("Arial Narrow", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonRegister.Location = new System.Drawing.Point(434, 404);
            this.buttonRegister.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonRegister.Name = "buttonRegister";
            this.buttonRegister.Size = new System.Drawing.Size(141, 68);
            this.buttonRegister.TabIndex = 17;
            this.buttonRegister.Text = "Register";
            this.buttonRegister.UseVisualStyleBackColor = false;
            this.buttonRegister.Click += new System.EventHandler(this.buttonRegister_Click);
            // 
            // RegPassword
            // 
            this.RegPassword.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RegPassword.ForeColor = System.Drawing.SystemColors.InfoText;
            this.RegPassword.Location = new System.Drawing.Point(153, 202);
            this.RegPassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.RegPassword.Name = "RegPassword";
            this.RegPassword.Size = new System.Drawing.Size(318, 33);
            this.RegPassword.TabIndex = 16;
            this.RegPassword.UseSystemPasswordChar = true;
            // 
            // RegName
            // 
            this.RegName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegName.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.RegName.Location = new System.Drawing.Point(153, 118);
            this.RegName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.RegName.Multiline = true;
            this.RegName.Name = "RegName";
            this.RegName.Size = new System.Drawing.Size(318, 33);
            this.RegName.TabIndex = 14;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gray;
            this.panel2.Controls.Add(this.CloseButton);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(729, 89);
            this.panel2.TabIndex = 12;
            // 
            // CloseButton
            // 
            this.CloseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseButton.BackColor = System.Drawing.Color.Transparent;
            this.CloseButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CloseButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CloseButton.Location = new System.Drawing.Point(1209, -2);
            this.CloseButton.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(0, 49);
            this.CloseButton.TabIndex = 2;
            this.CloseButton.Text = "x";
            this.CloseButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.Default;
            this.label2.Location = new System.Drawing.Point(12, 12);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 20);
            this.label2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(729, 89);
            this.label1.TabIndex = 0;
            this.label1.Text = "Registration";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLogin.Location = new System.Drawing.Point(469, 120);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(175, 26);
            this.labelLogin.TabIndex = 24;
            this.labelLogin.Text = "Login (>2 letters)";
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelID.Location = new System.Drawing.Point(469, 330);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(157, 26);
            this.labelID.TabIndex = 25;
            this.labelID.Text = "ID (9 numbers)";
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPassword.Location = new System.Drawing.Point(469, 209);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(260, 26);
            this.labelPassword.TabIndex = 26;
            this.labelPassword.Text = "Password (>5 characters)";
            // 
            // RegPassReenter
            // 
            this.RegPassReenter.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RegPassReenter.ForeColor = System.Drawing.SystemColors.InfoText;
            this.RegPassReenter.Location = new System.Drawing.Point(153, 242);
            this.RegPassReenter.Name = "RegPassReenter";
            this.RegPassReenter.Size = new System.Drawing.Size(318, 33);
            this.RegPassReenter.TabIndex = 27;
            this.RegPassReenter.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(469, 240);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(172, 26);
            this.label3.TabIndex = 28;
            this.label3.Text = "repeat password";
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(729, 529);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.RegPassReenter);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.labelID);
            this.Controls.Add(this.labelLogin);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.IDbox);
            this.Controls.Add(this.buttonRegister);
            this.Controls.Add(this.RegPassword);
            this.Controls.Add(this.RegName);
            this.Controls.Add(this.panel2);
            this.Name = "Register";
            this.Text = "Register";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Register_FormClosing);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.TextBox IDbox;
        private System.Windows.Forms.Button buttonRegister;
        private System.Windows.Forms.TextBox RegPassword;
        private System.Windows.Forms.TextBox RegName;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label CloseButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.TextBox RegPassReenter;
        private System.Windows.Forms.Label label3;
    }
}