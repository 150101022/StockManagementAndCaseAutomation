using Stok_Takibi.Models;
using Stok_Takibi.Pages;
using Stok_Takibi.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Stok_Takibi
{
    public partial class Employee : Form
    {
        public Employee()
        {
            string text = File.ReadAllText(System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location) + "\\languages\\tr.xml");
            Variables.XmlDocument = text;
            InitializeComponent();
        }

        private void TabControl1_Selected(Object sender, EventArgs e)
        {
            productDisplayTabPage.reassignGridViewRows_Click(sender, e);
            onTrustSaleDisplayTabPage.displayInformationsOnTrustSaleDisplayDataGridView_assignDatas();
        }

        public void refreshAll()
        {
            //this.Invalidate();
            //this.Update();
            //this.Refresh();
            
            Application.DoEvents();
            Application.Restart();
        }

        private void productManageTabControl_DrawItem(object sender, DrawItemEventArgs e)
        {
            string tabName = productManageWindowTabControl.TabPages[e.Index].Text;
            StringFormat stringFormat = new StringFormat();
            stringFormat.Alignment = StringAlignment.Center;
            stringFormat.LineAlignment = StringAlignment.Center;
            //Find if it is selected, this one will be hightlighted...
            if (e.Index == productManageWindowTabControl.SelectedIndex)
                e.Graphics.FillRectangle(Brushes.LightBlue, e.Bounds);
            e.Graphics.DrawString(tabName, new System.Drawing.Font("Microsoft Sans Serif", Convert.ToInt32(Variables.xmlDoc.SelectNodes("tr/sansSerif14FFont").Item(0).InnerText), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))),
                Brushes.Black, productManageWindowTabControl.GetTabRect(e.Index), stringFormat);
        }

        private void tabControl_DrawItem(object sender, DrawItemEventArgs e)
        {
            Graphics g = e.Graphics;
            System.Windows.Forms.TabPage tp = mainTabControl.TabPages[e.Index];

            StringFormat sf = new StringFormat();
            sf.Alignment = StringAlignment.Center;  //optional

            // This is the rectangle to draw "over" the tabpage title
            RectangleF headerRect = new RectangleF(e.Bounds.X, e
                .Bounds.Y + 2, e.Bounds.Width, e.Bounds.Height - 2);

            // This is the default colour to use for the non-selected tabs
            SolidBrush sb = new SolidBrush(Color.AntiqueWhite);

            // This changes the colour if we're trying to draw the selected tabpage
            if (mainTabControl.SelectedIndex == e.Index)
                sb.Color = Color.Aqua;

            // Colour the header of the current tabpage based on what we did above
            g.FillRectangle(sb, e.Bounds);

            //Remember to redraw the text - I'm always using black for title text
            g.DrawString(tp.Text, mainTabControl.Font, new SolidBrush(Color.Black), headerRect, sf);
        }

        private void ChangeTabColor(object sender, DrawItemEventArgs e)
        {
            Font TabFont;
            Brush BackBrush = new SolidBrush(Color.Green); //Set background color
            Brush ForeBrush = new SolidBrush(Color.Yellow);//Set foreground color
            if (e.Index == this.mainTabControl.SelectedIndex)
            {
                TabFont = new Font(e.Font.FontFamily, Convert.ToInt32(Variables.xmlDoc.SelectNodes("tr/sansSerif14FFont").Item(0).InnerText), FontStyle.Bold);
            }
            else
            {
                TabFont = e.Font;
            }
            string TabName = this.mainTabControl.TabPages[e.Index].Text;
            StringFormat sf = new StringFormat();
            sf.Alignment = StringAlignment.Center;
            e.Graphics.FillRectangle(BackBrush, e.Bounds);
            Rectangle r = e.Bounds;
            r = new Rectangle(r.X, r.Y + 3, r.Width, r.Height - 3);
            e.Graphics.DrawString(TabName, TabFont, ForeBrush, r, sf);
            //Dispose objects
            sf.Dispose();

            
            if (e.Index == this.mainTabControl.SelectedIndex)
            {
                TabFont.Dispose();
                BackBrush.Dispose();
            }
            else
            {
                BackBrush.Dispose();
                ForeBrush.Dispose();
            }
        }

        private void Employee_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void tabControl1_DrawItem(object sender, System.Windows.Forms.DrawItemEventArgs e)
        {
            Font fntTab;
            Brush bshBack;
            Brush bshFore;

            if (e.Index == mainTabControl.SelectedIndex)
            {
                fntTab = new Font(e.Font, FontStyle.Bold);
                bshBack = new System.Drawing.Drawing2D.LinearGradientBrush(e.Bounds, SystemColors.Control, SystemColors.Control, System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal);
                bshFore = Brushes.Black;
                //bshBack = new System.Drawing.Drawing2D.LinearGradientBrush(e.Bounds, Color.LightSkyBlue , Color.LightGreen, System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal);
                //bshFore = Brushes.Blue;
            }
            else
            {
                fntTab = e.Font;
                bshBack = new SolidBrush(Color.Red);
                bshFore = new SolidBrush(Color.Aqua);

                //bshBack = new SolidBrush(Color.White);
                //bshFore = new SolidBrush(Color.Black);
            }

            string tabName = mainTabControl.TabPages[e.Index].Text;
            StringFormat sftTab = new StringFormat();
            e.Graphics.FillRectangle(bshBack, e.Bounds);
            Rectangle recTab = e.Bounds;
            recTab = new Rectangle(recTab.X, recTab.Y + 4, recTab.Width, recTab.Height - 4);
            e.Graphics.DrawString(tabName, fntTab, bshFore, recTab, sftTab);


            Rectangle r = mainTabControl.GetTabRect(mainTabControl.TabPages.Count - 1);

            RectangleF tf =
                new RectangleF(r.X + r.Width,
                r.Y - 5, this.Width - (r.X + r.Width) + 5, r.Height + 5);
            Brush b = Brushes.BlueViolet;

            e.Graphics.FillRectangle(b, tf);
        }

        //protected override void OnPaintBackground(PaintEventArgs e)
        //{
        //    base.OnPaintBackground(e);
        //    Rectangle lasttabrect = mainTabControl.GetTabRect(mainTabControl.TabPages.Count - 1);
        //    RectangleF emptyspacerect = new RectangleF(
        //            lasttabrect.X + lasttabrect.Width + mainTabControl.Left,
        //            mainTabControl.Top + lasttabrect.Y,
        //            mainTabControl.Width - (lasttabrect.X + lasttabrect.Width),
        //            lasttabrect.Height);

        //    Brush b = Brushes.BlueViolet; // the color you want
        //    e.Graphics.FillRectangle(b, emptyspacerect);
        //}
    }
}
