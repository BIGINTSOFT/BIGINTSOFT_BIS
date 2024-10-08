using BIS.BLL.General;
using BIS.Common.Enums;
using BIS.Entity.Entities;
using BIS.UI.Forms.BaseForms;
using BIS.UI.Functions;
using BIS.UI.Show;
using BIS.UI.UserControls.Navigators;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BIS.UI.Forms.UserForms
{
    public partial class UserListForm : BaseListForm
    {
        public UserListForm()
        {
            InitializeComponent();
            Bll = new UserService();
        }

        protected override void DegiskenleriDoldur()
        {
            Tablo = tablo;
            //BaseListForm'dan gelen
            BaseKartTuru = KartTuru.User;
            //Double Click' olayında OkulEditForm açılacak
            FormShow = new ShowEditForms<UserEditForm>();
            Navigator = longNavigator1.Navigator;

        }

        protected override void Listele()
        {
            //List İçerisine filtre göndereceğiz
            Tablo.GridControl.DataSource = ((UserService)Bll).List(FilterFunctions.Filter<User>(AktifKartlariGoster));
        }
    }
}