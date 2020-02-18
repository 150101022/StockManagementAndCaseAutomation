using Stok_Takibi.Pages;
using System;
using System.Collections;
using System.Drawing;
using System.Windows.Forms;

namespace Stok_Takibi
{
    partial class Employee
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
            this.mainTabControl = new System.Windows.Forms.TabControl();
            this.productManageWindowTabControl = new System.Windows.Forms.TabControl();
            this.productManageWindowTabPage = new System.Windows.Forms.TabPage();
            this.components = new System.ComponentModel.Container();
            productAddTabPage = new ProductAddTabPage(Variables.userID);
            productDeleteTabPage = new ProductDeleteTabPage(Variables.userID);
            productDisplayTabPage = new ProductDisplayTabPage();
            productRegistrationTabPage = new ProductRegistrationTabPage(Variables.userID);
            onTrustSaleDisplayTabPage = new OnTrustSaleDisplayTabPage();
            // 
            // mainTabControl
            // 
            this.mainTabControl.Controls.Add(new SaleWindowTabPage());
            this.mainTabControl.Controls.Add(this.productManageWindowTabPage);
            this.mainTabControl.Controls.Add(new SaleOnTrustTabPage());
            this.mainTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTabControl.Name = "mainTabControl";
            //this.mainTabControl.DrawItem += new DrawItemEventHandler(tabControl1_DrawItem);
            //this.mainTabControl.DrawMode = TabDrawMode.OwnerDrawFixed;
            this.mainTabControl.SelectedIndex = 0;
            this.mainTabControl.BackColor = Color.White;
            this.mainTabControl.ForeColor = Color.Black;
            //this.mainTabControl.Alignment = TabAlignment.Left;
            //this.mainTabControl.Appearance = TabAppearance.FlatButtons;
            //this.mainTabControl.DrawMode = TabDrawMode.OwnerDrawFixed;
            //this.mainTabControl.DrawItem += tabControl_DrawItem;
            this.mainTabControl.Font = new System.Drawing.Font("Microsoft Sans Serif", Convert.ToInt32(Variables.xmlDoc.SelectNodes("tr/sansSerif14FFont").Item(0).InnerText), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainTabControl.TabIndex = 0;
            //System.Windows.Forms.TabPage selectedTab = mainTabControl.SelectedTab;
            //int selectedIndex = mainTabControl.SelectedIndex;
            //mainTabControl.SelectedTab = selectedTab;

            // 
            // productManageWindowTabControl
            // 
            this.productManageWindowTabControl.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.productManageWindowTabControl.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.productManageWindowTabControl.Controls.Add(productAddTabPage);
            this.productManageWindowTabControl.Controls.Add(productDeleteTabPage);
            this.productManageWindowTabControl.Controls.Add(productRegistrationTabPage);
            this.productManageWindowTabControl.Controls.Add(productDisplayTabPage);
            this.productManageWindowTabControl.Controls.Add(onTrustSaleDisplayTabPage);
            this.productManageWindowTabControl.SelectedIndexChanged += new EventHandler(TabControl1_Selected);
            this.productManageWindowTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            //this.productManageWindowTabControl.Selected += new TabControlEventHandler(this.) 
            this.productManageWindowTabControl.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.productManageWindowTabControl.ItemSize = new System.Drawing.Size(60, 240);
            this.productManageWindowTabControl.Multiline = true;
            this.productManageWindowTabControl.Name = "Ürün işlemleri";
            this.productManageWindowTabControl.SelectedIndex = 0;
            this.productManageWindowTabControl.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.productManageWindowTabControl.TabIndex = 0;
            this.productManageWindowTabControl.Tag = "";
            this.productManageWindowTabControl.Font = new System.Drawing.Font("Microsoft Sans Serif", Convert.ToInt32(Variables.xmlDoc.SelectNodes("tr/sansSerif14FFont").Item(0).InnerText), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productManageWindowTabControl.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.productManageTabControl_DrawItem);
            // 
            // productManageWindowTabPage
            // 
            this.productManageWindowTabPage.Controls.Add(this.productManageWindowTabControl);
            this.productManageWindowTabPage.Name = "productManageWindowTabPage";
            this.productManageWindowTabPage.TabIndex = 1;
            this.productManageWindowTabPage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.productManageWindowTabPage.Font = new System.Drawing.Font("Microsoft Sans Serif", Convert.ToInt32(Variables.xmlDoc.SelectNodes("tr/sansSerif14FFont").Item(0).InnerText), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productManageWindowTabPage.Text = "Ürün Yönetimi";
            this.productManageWindowTabPage.UseVisualStyleBackColor = true;
            // 
            // Employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Controls.Add(this.mainTabControl);
            this.FormClosed += Employee_FormClosed;
            this.Name = "Employee";
            this.Text = "TabControlTest";
            this.MinimumSize = new Size(800, 500);
            //this.BackColor = ColorTranslator.FromHtml(Variables.xmlDoc.SelectNodes("tr/mainBackColor").Item(0).InnerText);
            this.ForeColor = Color.White;
            this.mainTabControl.ResumeLayout(false);
            this.ResumeLayout(false);
        }        

        #endregion
        private System.Windows.Forms.TabControl mainTabControl;
        private System.Windows.Forms.TabControl productManageWindowTabControl;
        private System.Windows.Forms.TabPage productManageWindowTabPage;
        ProductAddTabPage productAddTabPage;
        ProductDeleteTabPage productDeleteTabPage;
        ProductDisplayTabPage productDisplayTabPage;
        ProductRegistrationTabPage productRegistrationTabPage;
        OnTrustSaleDisplayTabPage onTrustSaleDisplayTabPage;
    }
}