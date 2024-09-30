using BIS.Common.Enums;
using BIS.Entity.Entities.Base;
using BIS.UI.Forms.BaseForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BIS.UI.Show
{
    public class ShowListForms<TForm> where TForm : BaseListForm
    {
        //Burası Show olarak açılıyor
        public static void ShowListForm(KartTuru kartTuru)
        {
            //Yetki Kontrolleri yapılacak


            //Form'umuz geliyıor , üzerinden işlem yapabileceğiz
            var frm = (TForm)Activator.CreateInstance(typeof(TForm));

            //MdiParent ' aktif form hangisiyse sahibii odur.
            frm.MdiParent = Form.ActiveForm;

            //Yukle Fonksiyonunu çağırıyoruz .
            frm.Yukle();
            frm.Show();
        }

        public static void ShowListForm(KartTuru kartTuru, params object[] prm)
        {
            //Yetki Kontrolleri yapılacak


            //Form'umuz geliyıor , üzerinden işlem yapabileceğiz
            var frm = (TForm)Activator.CreateInstance(typeof(TForm), prm);

            //MdiParent ' aktif form hangisiyse sahibii odur.
            frm.MdiParent = Form.ActiveForm;

            //Yukle Fonksiyonunu çağırıyoruz .
            frm.Yukle();
            frm.Show();
        }

        public static BaseEntity ShowDialogListForm(KartTuru kartTuru, long? seciliGelecekId, params object[] prm)
        {
            // Yetki kontrolü gelecek

            using (var frm = (TForm)Activator.CreateInstance(typeof(TForm), prm))
            {
                frm.SeciliGelecekId = seciliGelecekId;
                frm.Yukle();
                frm.ShowDialog();

                return frm.DialogResult == DialogResult.OK ? frm.SelectedEntity : null;
            }

        }
    }
}
