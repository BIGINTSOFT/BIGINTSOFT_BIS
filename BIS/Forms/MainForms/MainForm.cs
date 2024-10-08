using BIS.Common.Enums;
using BIS.UI;
using BIS.UI.Forms.UserForms;
using BIS.UI.Show;
using DevExpress.XtraBars;
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
            EventsLoad();

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

        private void EventsLoad()
        {
            //Header menüdeki Ribborn Control de dolaşıyoruz
            foreach (var item in ribbonControl1.Items)
            {
                switch (item)
                {
                    case BarButtonItem btn:
                        btn.ItemClick += Butonlar_ItemClick;
                        break;


                }

            }
        }


        private void Butonlar_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (e.Item == btnUserCard)
            {
                ShowListForms<UserListForm>.ShowListForm(KartTuru.User);
            }

        }

        private void btnItemSettings_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			var settingsForm = new SettingsForm();
			settingsForm.ShowDialog();
		}
	
	}
}
