using BIS.BLL.Base;
using BIS.BLL.DTO;
using BIS.BLL.Interfaces;
using BIS.Common.Enums;
using BIS.Data.Contexts;
using BIS.Entity.Entities;
using BIS.Entity.Entities.Base;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq.Expressions;

namespace BIS.BLL.General
{

    public class UserService : BaseGenelService<User>, IBaseGenelService, IBaseCommonService
    {
        //Ctor 'leri oluşturuyoruz : İşlem Yapmayacağız ..
        private readonly AppDbContext _context;




        //Kart Türünü Base olarak gönderiyoruz ...
        public UserService() : base(KartTuru.User)
        {
        }

        public UserService(Control ctrl) : base(ctrl, KartTuru.User) {
        }

        //BaseBll'deki Single TResult Türünde ve TResult ise BaseEntity olacağı için geriye BaseEntity gönderecek.
        public override BaseEntity Single(Expression<Func<User, bool>> filter)
        {
            //Seçim işlemini selector burada devreye giricek fonksiyon parametresinde değil.
            //Burada Selector için Data Transfer Object Oluşturacağız DTO ..
            return BaseSingle(filter, x => new UserDTO
            {
                //Property'leri böyle kullanacağız. DTO kullanmış olduk
                Id = x.Id,
                Kod = x.Kod,
                UserName = x.UserName,
                UserSurname = x.UserSurname,
                Email = x.Email,
                EmployeeStatusId = x.EmployeeStatus.Id,
                Phone = x.Phone,
                CreatedDate = x.CreatedDate,
                EmployeeStatus=x.EmployeeStatus.StatusName,
                IsActive=x.IsActive,
                ProfilePicture = x.ProfilePicture,
            });
        }

        public override IEnumerable<BaseEntity> List(Expression<Func<User, bool>> filter)
        {
            //BaseList IQueryable türünde döndüğü için bunu ekrana getirirken sıralama ve Listeleme yapıyoruz.
            //Burada ToList() döndürmemizin sebebi OrderBy ile filtre uygulamamız . Yani İlk Sıralama Sonra Listeleme işlemi
            return BaseList(filter, x => new UserDTO
            {
                Id = x.Id,
                Kod = x.Kod,
                UserName = x.UserName,
                UserSurname = x.UserSurname,
                Email = x.Email,
                EmployeeStatusId = x.EmployeeStatus.Id,
                Phone = x.Phone,
                CreatedDate = x.CreatedDate,
                EmployeeStatus = x.EmployeeStatus.StatusName,
            }).OrderBy(x => x.Kod).ToList();
        }

        

        public (User user, string errorMessage) ValidateUser(string username, string password)
        {
            try
            {
                // Kullanıcıyı doğrulama işlemi
                var user = _context.Users.FirstOrDefault(u => u.UserName == username && u.Password == password);

                if (user == null)
                {
                    return (null, "Kullanıcı adı veya şifre hatalı.");
                }

                return (user, null);
            }
            catch (Exception ex)
            {
                return (null, $"Bir hata oluştu: {ex.Message}");
            }
        }

        public List<EmployeeStatus> GetEmployeeStatuses()
        {
            try
            {
                return _context.EmployeeStatus.ToList();  // Veritabanından EmployeeStatus verilerini çekiyoruz
            }
            catch (Exception ex)
            {

                throw;
            }

        }
    }

    //public class UserService
    //{
    //    private readonly AppDbContext _context;

    //    //public UserService(AppDbContext context)
    //    //{
    //    //    _context = context;
    //    //}

    //    //public (User user, string errorMessage) ValidateUser(string username, string password)
    //    //{
    //    //    try
    //    //    {
    //    //        // Kullanıcıyı doğrulama işlemi
    //    //        var user = _context.Users.FirstOrDefault(u => u.UserName == username && u.Password == password);

    //    //        if (user == null)
    //    //        {
    //    //            return (null, "Kullanıcı adı veya şifre hatalı.");
    //    //        }

    //    //        return (user, null);
    //    //    }
    //    //    catch (Exception ex)
    //    //    {
    //    //        return (null, $"Bir hata oluştu: {ex.Message}");
    //    //    }
    //    //}

    //    //public (bool isSuccess, string errorMessage) CreateUser(User user)
    //    //{
    //    //    try
    //    //    {
    //    //        _context.Users.Add(user);
    //    //        _context.SaveChanges();

    //    //        return (true, null);
    //    //    }
    //    //    catch (Exception ex)
    //    //    {
    //    //        return (false, $"Kullanıcı kaydedilirken hata oluştu: {ex.Message}");
    //    //    }
    //    //}

    //    //public List<EmployeeStatus> GetEmployeeStatuses()
    //    //{
    //    //    try
    //    //    {
    //    //        return _context.EmployeeStatus.ToList();  // Veritabanından EmployeeStatus verilerini çekiyoruz
    //    //    }
    //    //    catch (Exception ex)
    //    //    {

    //    //        throw;
    //    //    }

    //    //}

    //    //public List<UserDTO> GetUsers()
    //    //{
    //    //    return _context.Users
    //    //                   .Include(u => u.EmployeeStatus)
    //    //                   .Select(u => new UserDTO
    //    //                   {
    //    //                       Id = u.Id,
    //    //                       UserName = u.UserName,
    //    //                       UserSurname = u.UserSurname,
    //    //                       Email = u.Email,
    //    //                       Phone = u.Phone,
    //    //                       ProfilePicture = u.ProfilePicture,
    //    //                       EmployeeStatus = u.EmployeeStatus != null ? u.EmployeeStatus.StatusName : "N/A",
    //    //                       EmployeeStatusId = u.EmployeeStatusId ?? 0,
    //    //                       NationalId = u.NationalId,
    //    //                       IsActive = u.IsActive,
    //    //                       CreatedDate = u.CreatedDate
    //    //                   })
    //    //                   .ToList();
    //    //}
    //}
}
