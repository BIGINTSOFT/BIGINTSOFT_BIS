using BIS.UI;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BIS
{
	public partial class MainForm : DevExpress.XtraBars.Ribbon.RibbonForm
	{
		private readonly IServiceProvider _serviceProvider;
		private bool _isSysAdmin;
		public MainForm(bool isSysAdmin, IServiceProvider serviceProvider)
		{
			InitializeComponent();
			_isSysAdmin = isSysAdmin;
			InitializeMenu();
			_serviceProvider = serviceProvider;

			this.IsMdiContainer = true;
		}
		private void InitializeMenu()
		{
			if (_isSysAdmin)
			{
				//btnItemSettings.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
				settingsRibonPage.Visible = true;
			}
		}

		private void btnItemSettings_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			var settingsForm = new SettingsForm();
			settingsForm.ShowDialog();
		}

		private void ribbonControl1_Click(object sender, EventArgs e)
		{

		}

		private void MainForm_Load(object sender, EventArgs e)
		{

		}

		private void btnUserCard_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			var usersForm = _serviceProvider.GetRequiredService<Users>();
			usersForm.MdiParent = this;  // Formu ana forma MDI child olarak ekliyoruz
			usersForm.Show();
		}
	}
}
