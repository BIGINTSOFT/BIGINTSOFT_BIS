﻿namespace BIS.UI.Forms.MainForms
{
    partial class AnaForm
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
            this.ribbonControl = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnOkulKartlari = new DevExpress.XtraBars.BarButtonItem();
            this.btnIlKartlari = new DevExpress.XtraBars.BarButtonItem();
            this.btnVeliBilgiKartlari = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar1 = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.xtraTabbedMdiManager = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            this.btnIptalNedeniKartlari = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl
            // 
            this.ribbonControl.ExpandCollapseItem.Id = 0;
            this.ribbonControl.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl.ExpandCollapseItem,
            this.ribbonControl.SearchEditItem,
            this.btnOkulKartlari,
            this.btnIlKartlari,
            this.btnVeliBilgiKartlari,
            this.btnIptalNedeniKartlari});
            this.ribbonControl.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl.MaxItemId = 5;
            this.ribbonControl.Name = "ribbonControl";
            this.ribbonControl.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl.Size = new System.Drawing.Size(828, 143);
            this.ribbonControl.StatusBar = this.ribbonStatusBar1;
            // 
            // btnOkulKartlari
            // 
            this.btnOkulKartlari.Caption = "Okul Kartları";
            this.btnOkulKartlari.Id = 1;
            this.btnOkulKartlari.ImageOptions.Image = global::BIS.UI.Properties.Resources.home_16x16;
            this.btnOkulKartlari.ImageOptions.LargeImage = global::BIS.UI.Properties.Resources.home_32x32;
            this.btnOkulKartlari.Name = "btnOkulKartlari";
            // 
            // btnIlKartlari
            // 
            this.btnIlKartlari.Caption = "İl Kartları";
            this.btnIlKartlari.Id = 2;
            this.btnIlKartlari.Name = "btnIlKartlari";
            // 
            // btnVeliBilgiKartlari
            // 
            this.btnVeliBilgiKartlari.Caption = "Veli Bilgi Kartları";
            this.btnVeliBilgiKartlari.Id = 3;
            this.btnVeliBilgiKartlari.Name = "btnVeliBilgiKartlari";
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "ribbonPage1";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btnOkulKartlari);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnIlKartlari);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnVeliBilgiKartlari);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnIptalNedeniKartlari);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            // 
            // ribbonStatusBar1
            // 
            this.ribbonStatusBar1.Location = new System.Drawing.Point(0, 562);
            this.ribbonStatusBar1.Name = "ribbonStatusBar1";
            this.ribbonStatusBar1.Ribbon = this.ribbonControl;
            this.ribbonStatusBar1.Size = new System.Drawing.Size(828, 31);
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "ribbonPage2";
            // 
            // xtraTabbedMdiManager
            // 
            this.xtraTabbedMdiManager.MdiParent = this;
            // 
            // btnIptalNedeniKartlari
            // 
            this.btnIptalNedeniKartlari.Caption = "İptal Nedeni Kartları";
            this.btnIptalNedeniKartlari.Id = 4;
            this.btnIptalNedeniKartlari.Name = "btnIptalNedeniKartlari";
            // 
            // AnaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 593);
            this.Controls.Add(this.ribbonStatusBar1);
            this.Controls.Add(this.ribbonControl);
            this.IsMdiContainer = true;
            this.Name = "AnaForm";
            this.Ribbon = this.ribbonControl;
            this.StatusBar = this.ribbonStatusBar1;
            this.Text = "AnaForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.BarButtonItem btnOkulKartlari;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager;
        private DevExpress.XtraBars.BarButtonItem btnIlKartlari;
        private DevExpress.XtraBars.BarButtonItem btnVeliBilgiKartlari;
        private DevExpress.XtraBars.BarButtonItem btnIptalNedeniKartlari;
    }
}