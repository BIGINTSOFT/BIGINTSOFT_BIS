using BIS.BLL.DTO;
using BIS.BLL.General;
using BIS.Common.Enums;
using BIS.Entity.Entities;
using BIS.UI.Forms.BaseForms;
using BIS.UI.Functions;
using BIS.UI.UserControls.Controls;
using DevExpress.XtraDataLayout;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BIS.UI.Forms.UserForms
{
    public partial class UserEditForm : BaseEditForm
    {
        public UserEditForm()
        {
            InitializeComponent();

            DataLayoutControl = myDataLayoutControl;

            Bll = new UserService(myDataLayoutControl);


            BaseEditKartTuru = KartTuru.User;

            //
            EventsLoad();
        }

        protected internal override void Yukle()
        {
            // Insert veya Update Olması durumunu kontrol ediyoruz Insert İse
            // Dto'dan instance alsın Update ' ise Single'ile çek getir.
            OldEntity = IslemTuru == IslemTuru.EntityInsert ? new UserDTO() : ((UserService)Bll).Single(FilterFunctions.Filter<User>(Id));
            NesneyiKontrollereBagla();

            //Entity insert olmadığı sürece çalıştırma
            if (IslemTuru != IslemTuru.EntityInsert) return;
            Id = IslemTuru.IdOlustur(OldEntity);
            //Txt'kod kısmına yeni kod oluşturup atacağız ... 
            txtKod.Text = ((UserService)Bll).YeniKodVer();

            LoadEmployeeStatusData();

            txtAd.Focus();
        }

        protected override void NesneyiKontrollereBagla()
        {
            //Gelen ' entityle kontrollere bağlayacağız
            //OkulS'ye cast etme nedeni içindeki İl İlçe Bunları da kullanabilmek için
            var entity = (UserDTO)OldEntity;


            txtKod.Text = entity.Kod;
            txtAd.Text = entity.UserName;
            txtSoyad.Text = entity.UserSurname;
            txtEmail.Text = entity.Email;
            lookUpEditCalisanStatu.EditValue = entity.EmployeeStatusId;
            txtPassword.Text = entity.Password;
            txtTCNo.Text = entity.CardNumber;
            txtTelefon.Text = entity.Phone;

            if (entity.ProfilePicture != null && entity.ProfilePicture.Length > 0)
            {
                using (var ms = new MemoryStream(entity.ProfilePicture))
                {
                    pctBoxUser.Image = Image.FromStream(ms); // ProfilePicture byte dizisini Image'e dönüştürüp PictureBox'a atama
                }
            }
            else
            {
                pctBoxUser.Image = null; // Eğer profil resmi yoksa boş bırak
            }

            tglDurum.IsOn = entity.Durum;
        }

        protected override void GuncelNesneOlustur()
        {
            //Db'ye gönderilen entity'den instance -> Gönderilen Değişiklikleri yakalayabileceğiz
            CurrentEntity = new User
            {
                Id = Id,
                Kod = txtKod.Text,
                UserName = txtAd.Text,
                UserSurname = txtSoyad.Text,
                CardNumber = txtTCNo.Text,
                Phone = txtTelefon.Text,
                Password = txtPassword.Text,
                Email = txtEmail.Text,
                ProfilePicture = ImageToByteArray(pctBoxUser.Image),
                EmployeeStatusId = (long?)lookUpEditCalisanStatu.EditValue,
                Durum = tglDurum.IsOn
            };
            //İşlemi son olarak Function çağırarak tamamlıyoruz ...
            ButonEnabledDurumu();
     

        }

        private void LoadEmployeeStatusData()
        {
            // Veritabanından EmployeeStatus listesini getiriyoruz
            var employeeStatusList = ((UserService)Bll).GetEmployeeStatuses(); // Veritabanı erişim katmanında GetAll metodunu oluşturun
            // LookUpEdit bileşenine veri kaynağını bağlayın
            lookUpEditCalisanStatu.Properties.DataSource = employeeStatusList;
            lookUpEditCalisanStatu.Properties.DisplayMember = "Description";  // Gösterilecek alan adı (EmployeeStatus'ta tanımlı)
            lookUpEditCalisanStatu.Properties.ValueMember = "Id";  // Seçildiğinde alacağımız değer
        }

        private byte[] ImageToByteArray(Image image)
        {
            if (image == null)
                return null;

            using (var ms = new MemoryStream())
            {
                image.Save(ms, image.RawFormat); // Image nesnesini MemoryStream'e kaydediyoruz.
                return ms.ToArray(); // MemoryStream'deki veriyi byte[] olarak geri döndürüyoruz.
            }
        }

        protected override void SecimYap(object sender)
        {
            if (!(sender is ButtonEdit))
            {
                //herhangi bir işlem yapma
                return;
            }
            //using (var sec = new SelectFunctions())
            //{
            //    if (sender == txtCalisanStatu)

            //        sec.Sec(txtCalisanStatu);
            //    //else if (sender == txtIlce)
            //    //    //prm olarak txtIl göndereceğiz
            //    //    sec.Sec(txtIlce, txtIl);
            //}
        }

        private void btnResimSec_Click(object sender, EventArgs e)
        {
            resimSecDialog.Filter = "Resim Dosyaları|*.jpg;*.jpeg;*.png;*.bmp";
            resimSecDialog.Title = "Bir resim seçin";

            if (resimSecDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = resimSecDialog.FileName;
                pctBoxUser.Image = Image.FromFile(filePath);
            }
        }

        //protected override void Control_EnabledChange(object sender, EventArgs e)
        //{
        //    if (sender != txtCalisanStatu) return;

        //    txtCalisanStatu.ControlEnabledChange(txtCalisanStatu);
        //}
    }
}