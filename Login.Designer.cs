using System;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Xml;

namespace Stok_Takibi
{
    partial class Login
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

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.usernameLoginTextBox = new System.Windows.Forms.TextBox();
            this.passwordLoginTextBox = new System.Windows.Forms.TextBox();
            this.enterLoginButton = new System.Windows.Forms.Button();
            this.exitLoginButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.tableLayoutPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // usernameLoginTextBox
            // 
            this.usernameLoginTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.usernameLoginTextBox.Location = new System.Drawing.Point(3, 69);
            this.usernameLoginTextBox.Name = "usernameLoginTextBox";
            this.usernameLoginTextBox.Size = new System.Drawing.Size(289, 20);
            this.usernameLoginTextBox.TabIndex = 0;
            this.usernameLoginTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.usernameLoginTextBox_Validating);
            // 
            // passwordLoginTextBox
            // 
            this.passwordLoginTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.passwordLoginTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.passwordLoginTextBox.Location = new System.Drawing.Point(3, 201);
            this.passwordLoginTextBox.Name = "passwordLoginTextBox";
            this.passwordLoginTextBox.PasswordChar = '*';
            this.passwordLoginTextBox.Size = new System.Drawing.Size(289, 20);
            this.passwordLoginTextBox.TabIndex = 1;
            this.passwordLoginTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.passwordLoginTextBox_Validating);
            // 
            // enterLoginButton
            // 
            this.enterLoginButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(79)))), ((int)(((byte)(254)))));
            this.enterLoginButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.enterLoginButton.FlatAppearance.BorderSize = 0;
            this.enterLoginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.enterLoginButton.ForeColor = System.Drawing.Color.White;
            this.enterLoginButton.Location = new System.Drawing.Point(3, 3);
            this.enterLoginButton.Name = "enterLoginButton";
            this.enterLoginButton.Size = new System.Drawing.Size(95, 54);
            this.enterLoginButton.TabIndex = 2;
            this.enterLoginButton.UseVisualStyleBackColor = false;
            this.enterLoginButton.Click += new System.EventHandler(this.enterLoginButton_Click);
            // 
            // exitLoginButton
            // 
            this.exitLoginButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(79)))), ((int)(((byte)(254)))));
            this.exitLoginButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.exitLoginButton.FlatAppearance.BorderSize = 0;
            this.exitLoginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitLoginButton.ForeColor = System.Drawing.Color.White;
            this.exitLoginButton.Location = new System.Drawing.Point(190, 3);
            this.exitLoginButton.Name = "exitLoginButton";
            this.exitLoginButton.Size = new System.Drawing.Size(96, 54);
            this.exitLoginButton.TabIndex = 3;
            this.exitLoginButton.UseVisualStyleBackColor = false;
            this.exitLoginButton.Click += new System.EventHandler(this.exitLoginButton_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 92.1875F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.8125F));
            this.tableLayoutPanel1.Controls.Add(this.usernameLoginTextBox, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.passwordLoginTextBox, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 5);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(197, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(320, 444);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel2.Controls.Add(this.enterLoginButton, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.exitLoginButton, 2, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 333);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(289, 60);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel3.TabIndex = 5;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel4.ColumnCount = 3;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.25F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.75F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel1, 1, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel4.TabIndex = 5;
            this.tableLayoutPanel4.Enter += new System.EventHandler(this.form_Enter);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Login_FormClosed);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private TextBox usernameLoginTextBox;
        private TextBox passwordLoginTextBox;
        private Button enterLoginButton;
        private Button exitLoginButton;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel3;
        private ErrorProvider errorProvider;        
        private TableLayoutPanel tableLayoutPanel4;
    }
}