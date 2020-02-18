using Stok_Takibi.Models;
using Stok_Takibi.Services;
using MetroFramework.Forms;
using System;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Xml;

namespace Stok_Takibi
{
    public partial class Login : Form
    {
        protected NotifyIcon MyIcon;
        public Login()
        {
            string text = File.ReadAllText(System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location) + "\\languages\\tr.xml");
            Variables.xmlDoc.LoadXml(text);
            InitializeComponent();
        }

        private void enterLoginButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(usernameLoginTextBox.Text) &&
                !string.IsNullOrWhiteSpace(passwordLoginTextBox.Text)) {
                var user = Variables._databaseService.GetUser(usernameLoginTextBox.Text);
                if (user != null && user.password == passwordLoginTextBox.Text)
                {
                    if (user.userType.Equals("admin"))
                    {

                    }
                    else
                    {
                        Employee employee = new Employee();
                        Variables.userID = user.ID;
                        this.Dispose();
                        employee.Show();
                    }

                    MyIcon.Icon = new Icon(System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location) + Variables.xmlDoc.SelectNodes("tr/iconLocation").Item(0).InnerText);
                    MyIcon.Visible = true;
                    MyIcon.Text = Variables.xmlDoc.SelectNodes("tr/iconNameNotificationIT").Item(0).InnerText;
                    MyIcon.BalloonTipTitle = Variables.xmlDoc.SelectNodes("tr/loginWindowNameIT").Item(0).InnerText;
                    MyIcon.BalloonTipText = Variables.xmlDoc.SelectNodes("tr/welcomeMessage").Item(0).InnerText + user.username;
                    MyIcon.ShowBalloonTip(3000);
                }
                else
                {
                    MessageBox.Show(Variables.xmlDoc.SelectNodes("tr/usernameOrPasswordErrorMessage").Item(0).InnerText + user.username);
                }
            }
            
        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {            
            Application.Exit();            
        }

        private void exitLoginButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        protected void usernameLoginTextBox_Validating(object sender,
   System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(usernameLoginTextBox.Text))
            {
                errorProvider.SetError(usernameLoginTextBox, Variables.xmlDoc.SelectNodes("tr/emptyOrWhiteSpaceErrorErrorProviderIT").Item(0).InnerText);
            }
            else
            {
                errorProvider.SetError(usernameLoginTextBox, "");
            }
        }

        protected void passwordLoginTextBox_Validating(object sender,
   System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(passwordLoginTextBox.Text))
            {
                Console.WriteLine(Variables.xmlDoc.SelectNodes("tr/emptyOrWhiteSpaceErrorErrorProviderIT").Item(0).InnerText);
                errorProvider.SetError(passwordLoginTextBox, Variables.xmlDoc.SelectNodes("tr/emptyOrWhiteSpaceErrorErrorProviderIT").Item(0).InnerText);
            }
            else
            {
                errorProvider.SetError(passwordLoginTextBox, "");
            }
        }

        private void form_Enter(object sender, EventArgs e)
        {
            this.enterLoginButton.Text = Variables.xmlDoc.SelectNodes("tr/enterLoginButtonIT").Item(0).InnerText;
            this.exitLoginButton.Text = Variables.xmlDoc.SelectNodes("tr/exitLoginButtonIT").Item(0).InnerText;
            this.enterLoginButton.Font = new System.Drawing.Font("Microsoft Sans Serif", Convert.ToInt32(Variables.xmlDoc.SelectNodes("tr/sansSerif14FFont").Item(0).InnerText), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitLoginButton.Font = new System.Drawing.Font("Microsoft Sans Serif", Convert.ToInt32(Variables.xmlDoc.SelectNodes("tr/sansSerif14FFont").Item(0).InnerText), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameLoginTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", Convert.ToInt32(Variables.xmlDoc.SelectNodes("tr/sansSerif14FFont").Item(0).InnerText), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLoginTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", Convert.ToInt32(Variables.xmlDoc.SelectNodes("tr/sansSerif14FFont").Item(0).InnerText), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanel1.BringToFront();
            Image backgoundImage = new Bitmap(System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location) + Variables.xmlDoc.SelectNodes("tr/loginBackgroundImage").Item(0).InnerText);
            this.BackgroundImage = backgoundImage;
        }
    }
}
