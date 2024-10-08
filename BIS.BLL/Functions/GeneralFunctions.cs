using BIS.DAL.Base;
using BIS.DAL.Interfaces;
using BIS.Data.Contexts;
using BIS.Entity.Entities.Base.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BIS.BLL.Functions
{
    public static class GeneralFunctions
    {
        private static IConfiguration _configuration;

        // IConfiguration'ı sınıfa tanıtmak için bir Initialize metodu ekliyoruz
        public static void Initialize(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        // ConnectionString'i almak için metot
        public static string GetConnectionString()
        {
            return _configuration.GetConnectionString("DefaultConnection");
        }
        //Extension metot olarak tanımlanması için static ve this keywordu kullanılması gerekiyor
        public static IList<string> DegisenAlanlariGetir<T>(this T oldEntity, T currentEntity)
        {
            //Interface'lerin instance'ı alınamaz !!!
            IList<string> alanlar = new List<string>();

            foreach (var prop in currentEntity.GetType().GetProperties())
            {
                // ICollection Tipinde bi Property' sahip ise örnek ICollection<Ilce> Ilce tipinde ise işlem yapmadan devam et
                if (prop.PropertyType.Namespace == "System.Collections.Generic") continue;
                // Gelen değer Null ise String.Empty yap -> Karşılaştırabilmesi için Emptye dönüştürdük.
                var oldValue = prop.GetValue(oldEntity) ?? string.Empty;

                var currentValue = prop.GetValue(currentEntity) ?? string.Empty;

                //Örnek PRopertyler Byte Dizisi şeklindeyse -> Resim Dosyası
                if (prop.PropertyType == typeof(byte[]))
                {
                    if (string.IsNullOrEmpty(oldValue.ToString()))
                    {
                        //Eğer oldValue null veya empty ise byte oluştur ve Default 0 ata
                        oldValue = new byte[] { 0 };
                    }

                    if (string.IsNullOrEmpty(currentValue.ToString()))
                    {
                        //Eğer currentValue null veya empty ise byte oluştur ve Default 0 ata
                        currentValue = new byte[] { 0 };
                    }
                    //Byte'a cast edip Uzunluğunu alıyoruz.
                    if (((byte[])oldValue).Length != ((byte[])currentValue).Length)
                    {
                        alanlar.Add(prop.Name);
                    }

                }
                //Eşit değil ise
                else if (!currentValue.Equals(oldValue))
                {
                    alanlar.Add(prop.Name);
                }

            }

            return alanlar;

        }

        //Genel Fonksiyonlar Bölümü


        //TContext'i ne olduğunu tanımlamamız lazım -> new() ile instance alınabildiğini ve geri gönderebiliriz.
        private static TContext CreateContext<TContext>() where TContext : DbContext
        {
            var connectionString = GetConnectionString();

            // DbContextOptionsBuilder kullanarak context için seçenekler oluşturuyoruz
            var optionsBuilder = new DbContextOptionsBuilder<TContext>();
            optionsBuilder.UseSqlServer(connectionString);

            // DbContextOptions ile birlikte TContext instance oluşturuyoruz
            return (TContext)Activator.CreateInstance(typeof(TContext), optionsBuilder.Options);
        }

        //Referans olarak Interfacei aldık -> T : Model katmanındaki genel Entity olan IBaseEntity interface'i
        public static void CreateUnitOfWork<T, TContext>(ref IUnitOfWork<T> uow) where T : class, IBaseEntity where TContext : DbContext
        {
            //uow'un son haline ulaşacağımız için başta var ise dispose ediceğiz
            // ? null değil ise
            uow?.Dispose();
            //Burada Yeni Bir UnitofWork Oluşturmuş olduk.
            uow = new UnitOfWork<T>(CreateContext<TContext>());
        }

    }
}
