﻿using BIS.Common.Enums;
using BIS.Entity.Entities.Base.Interfaces;
using BIS.UI.Forms.BaseForms;
using BIS.UI.Show.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BIS.UI.Show
{
    //BaseKartForm' BaseEditForm olarak düzenledik
    public class ShowEditForms<TForm> : IBaseFormShow where TForm : BaseEditForm
    {

        public long ShowDialogEditForm(KartTuru kartTuru, long id) //,params object[] pre)
        {
            //Yetki Kontrolü buraya yapılacak
            //Açmış olarak formlar'ı IDisposable 'dan da implemente olabildiği için Bu işlemi yapacağız
            //using bloklarında Formun Type'ını göndreceğiz //TForm'a cast ediyoruz.
            using (var frm = (TForm)Activator.CreateInstance(typeof(TForm)))
            {
                //Enum'a değer atayarak ulaşacğız Common sınıfında bu işler yapılacak
                // ID : 0 dan büyükse Update değilse Insert olacak , 
                frm.IslemTuru = id > 0 ? IslemTuru.EntityUpdate : IslemTuru.EntityInsert;
                //Id : BaseEditForm'dan gelecek Id  
                frm.Id = id;
                //Formu Yükleme işlemi
                frm.Yukle();
                //Daha Sonra Dialog olarak açılacak
                frm.ShowDialog();

                //Formun içerisinde değişiklik var ise kontrol işlemi
                return frm.RefreshYapilacak ? frm.Id : 0;


            }
        }

        //İlçe Edit Form'ları için gerekli prm olarak Il Adi ve Il Id allacak
        public static long ShowDialogEditForm(KartTuru kartTuru, long id, params object[] prm) //,params object[] pre)
        {


            using (var frm = (TForm)Activator.CreateInstance(typeof(TForm), prm))
            {

                frm.IslemTuru = id > 0 ? IslemTuru.EntityUpdate : IslemTuru.EntityInsert;
                //Id : BaseEditForm'dan gelecek Id  
                frm.Id = id;
                //Formu Yükleme işlemi
                frm.Yukle();
                //Daha Sonra Dialog olarak açılacak
                frm.ShowDialog();

                //Formun içerisinde değişiklik var ise kontrol işlemi
                return frm.RefreshYapilacak ? frm.Id : 0;


            }
        }

        public static T ShowDialogEditForm<T>(params object[] prm) where T : IBaseEntity
        {
            using (var frm = (TForm)Activator.CreateInstance(typeof(TForm), prm))
            {
                //Formu Yükleme işlemi
                frm.Yukle();
                //Daha Sonra Dialog olarak açılacak
                frm.ShowDialog();

                return (T)frm.ReturnEntity();

            }
        }



    }
}