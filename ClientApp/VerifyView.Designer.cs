﻿namespace ClientApp
{
    partial class VerifyView
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.myApplicationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.prodDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giverDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myApplicationBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.prodDataGridViewTextBoxColumn,
            this.giverDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.myApplicationBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(-2, 1);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(488, 388);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // myApplicationBindingSource
            // 
            this.myApplicationBindingSource.DataSource = typeof(Lombard_Project.UserClasses.MyApplication);
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
            // buttonBack
            // 
            this.buttonBack.BackColor = System.Drawing.SystemColors.Control;
            this.buttonBack.FlatAppearance.BorderSize = 0;
            this.buttonBack.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.buttonBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.buttonBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBack.Location = new System.Drawing.Point(12, 395);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(122, 57);
            this.buttonBack.TabIndex = 4;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // VerifyView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.dataGridView1);
            this.Name = "VerifyView";
            this.Text = "VerifyView";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.VerifyView_FormClosing);
            this.Load += new System.EventHandler(this.VerifyView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myApplicationBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn giverDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource myApplicationBindingSource;
        private System.Windows.Forms.Button buttonBack;
    }
}