using BIS.BLL.DTO;
using BIS.Data.Contexts;
using BIS.Entity.Entities;
using Microsoft.EntityFrameworkCore;
using System;

namespace BIS.BLL
{
	public class UserService
	{
		private readonly AppDbContext _context;

		public UserService(AppDbContext context)
		{
			_context = context;
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

		public (bool isSuccess, string errorMessage) CreateUser(User user)
		{
			try
			{
				_context.Users.Add(user);
				_context.SaveChanges();

				return (true, null);
			}
			catch (Exception ex)
			{
				return (false, $"Kullanıcı kaydedilirken hata oluştu: {ex.Message}");
			}
		}

		public List<EmployeeStatus> GetEmployeeStatuses()
		{
			return _context.EmployeeStatus.ToList();  // Veritabanından EmployeeStatus verilerini çekiyoruz
		}

		public List<UserDTO> GetUsers()
		{
			return _context.Users
						   .Include(u => u.EmployeeStatus)
						   .Select(u => new UserDTO
						   {
							   Id = u.Id,
							   UserName = u.UserName,
							   UserSurname = u.UserSurname,
							   Email = u.Email,
							   Phone = u.Phone,
							   ProfilePicture = u.ProfilePicture,
							   EmployeeStatus = u.EmployeeStatus != null ? u.EmployeeStatus.StatusName : "N/A",
							   EmployeeStatusId = u.EmployeeStatusId ?? 0,
							   NationalId = u.NationalId,
							   IsActive = u.IsActive,
							   CreatedDate = u.CreatedDate
						   })
						   .ToList();
		}
	}
}
