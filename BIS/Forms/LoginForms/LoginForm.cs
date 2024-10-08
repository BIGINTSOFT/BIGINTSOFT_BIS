using DevExpress.XtraWaitForm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraReports.Design;
using Microsoft.Extensions.DependencyInjection;
using BIS.BLL.General;
using BIS.UI.Forms.MainForms;

namespace BIS.UI
{
    public partial class LoginForm : Form
	{
		private readonly UserService _userService;
		private readonly IServiceProvider _serviceProvider;
		public LoginForm(UserService userService, IServiceProvider serviceProvider)
		{
			InitializeComponent();
			_userService = userService;
			_serviceProvider = serviceProvider;
		}

		private void button1_Click(object sender, EventArgs e)
		{
			string username = textBox1.Text;
			string password = textBox2.Text;

			if (username == "sysadmin" && password == "syspasswordubm")
			{
				// Sysadmin giriş yaptı, MainForm'u aç
				var mainForm = new MainForm(true,_serviceProvider);
				mainForm.Show();
				this.Hide();
			}
			else
			{
				// Veritabanında kullanıcı kontrolü yap
				var (user, errorMessage) = _userService.ValidateUser(username, password);

				if (user != null)
				{
					// Kullanıcı doğrulandı, MainForm'u aç
					var mainForm = new MainForm(false, _serviceProvider);
                    mainForm.Show();
					this.Hide();
				}
				else
				{
					// Hata mesajı göster
					MessageBox.Show(errorMessage);
				}
			}
		}
	}
}
