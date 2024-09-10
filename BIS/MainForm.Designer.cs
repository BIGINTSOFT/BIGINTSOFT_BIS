namespace BIS
{
	partial class MainForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
			btnItemSettings = new DevExpress.XtraBars.BarButtonItem();
			btnUserCard = new DevExpress.XtraBars.BarButtonItem();
			barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
			barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
			settingsRibonPage = new DevExpress.XtraBars.Ribbon.RibbonPage();
			settingsPageGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
			definitionsRibonPage = new DevExpress.XtraBars.Ribbon.RibbonPage();
			userPageGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
			((System.ComponentModel.ISupportInitialize)ribbonControl1).BeginInit();
			SuspendLayout();
			// 
			// ribbonControl1
			// 
			ribbonControl1.ExpandCollapseItem.Id = 0;
			ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] { ribbonControl1.ExpandCollapseItem, btnItemSettings, btnUserCard, barButtonItem1, barButtonItem2 });
			ribbonControl1.Location = new System.Drawing.Point(0, 0);
			ribbonControl1.MaxItemId = 6;
			ribbonControl1.Name = "ribbonControl1";
			ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] { settingsRibonPage, definitionsRibonPage });
			ribbonControl1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.MacOffice;
			ribbonControl1.Size = new System.Drawing.Size(1367, 141);
			ribbonControl1.Click += ribbonControl1_Click;
			// 
			// btnItemSettings
			// 
			btnItemSettings.Caption = "Settings";
			btnItemSettings.Id = 1;
			btnItemSettings.ImageOptions.Image = (System.Drawing.Image)resources.GetObject("btnItemSettings.ImageOptions.Image");
			btnItemSettings.ImageOptions.LargeImage = (System.Drawing.Image)resources.GetObject("btnItemSettings.ImageOptions.LargeImage");
			btnItemSettings.Name = "btnItemSettings";
			btnItemSettings.ItemClick += btnItemSettings_ItemClick;
			// 
			// btnUserCard
			// 
			btnUserCard.Caption = "Kullanıcılar";
			btnUserCard.Id = 3;
			btnUserCard.ImageOptions.Image = (System.Drawing.Image)resources.GetObject("btnUserCard.ImageOptions.Image");
			btnUserCard.ImageOptions.LargeImage = (System.Drawing.Image)resources.GetObject("btnUserCard.ImageOptions.LargeImage");
			btnUserCard.Name = "btnUserCard";
			btnUserCard.ItemClick += btnUserCard_ItemClick;
			// 
			// barButtonItem1
			// 
			barButtonItem1.Caption = "barButtonItem1";
			barButtonItem1.Id = 4;
			barButtonItem1.Name = "barButtonItem1";
			// 
			// barButtonItem2
			// 
			barButtonItem2.Caption = "barButtonItem2";
			barButtonItem2.Id = 5;
			barButtonItem2.Name = "barButtonItem2";
			// 
			// settingsRibonPage
			// 
			settingsRibonPage.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] { settingsPageGroup });
			settingsRibonPage.Name = "settingsRibonPage";
			settingsRibonPage.Text = "Ayarlar";
			// 
			// settingsPageGroup
			// 
			settingsPageGroup.ItemLinks.Add(btnItemSettings);
			settingsPageGroup.Name = "settingsPageGroup";
			settingsPageGroup.Text = "Settings Group";
			// 
			// definitionsRibonPage
			// 
			definitionsRibonPage.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] { userPageGroup });
			definitionsRibonPage.Name = "definitionsRibonPage";
			definitionsRibonPage.Text = "Tanımlamalar";
			// 
			// userPageGroup
			// 
			userPageGroup.ItemLinks.Add(btnUserCard);
			userPageGroup.Name = "userPageGroup";
			userPageGroup.Text = "Kullanıcı";
			// 
			// MainForm
			// 
			AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			ClientSize = new System.Drawing.Size(1367, 728);
			Controls.Add(ribbonControl1);
			Name = "MainForm";
			Ribbon = ribbonControl1;
			Text = "Form1";
			Load += MainForm_Load;
			((System.ComponentModel.ISupportInitialize)ribbonControl1).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
		private DevExpress.XtraBars.Ribbon.RibbonPage settingsRibonPage;
		private DevExpress.XtraBars.Ribbon.RibbonPageGroup settingsPageGroup;
		private DevExpress.XtraBars.BarButtonItem btnItemSettings;
		private DevExpress.XtraBars.BarButtonItem btnUserCard;
		private DevExpress.XtraBars.Ribbon.RibbonPage definitionsRibonPage;
		private DevExpress.XtraBars.Ribbon.RibbonPageGroup userPageGroup;
		private DevExpress.XtraBars.BarButtonItem barButtonItem1;
		private DevExpress.XtraBars.BarButtonItem barButtonItem2;
	}
}

