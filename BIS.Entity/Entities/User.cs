using System;
using System.ComponentModel.DataAnnotations;

namespace BIS.Entity.Entities
{
	public class User
	{
		public int Id { get; set; }

		[Required(ErrorMessage = "Kullanıcı adı zorunludur.")]
		[StringLength(50, ErrorMessage = "Kullanıcı adı 50 karakteri geçemez.")]
		public string UserName { get; set; }

		[Required(ErrorMessage = "Kullanıcı soyadı zorunludur.")]
		[StringLength(50, ErrorMessage = "Kullanıcı soyadı 50 karakteri geçemez.")]
		public string UserSurname { get; set; }

		[Required(ErrorMessage = "Şifre zorunludur.")]
		[StringLength(100, MinimumLength = 6, ErrorMessage = "Şifre en az 6 karakter uzunluğunda olmalıdır.")]
		public string Password { get; set; }

		[EmailAddress(ErrorMessage = "Geçersiz e-posta adresi.")]
		public string? Email { get; set; }

		[Phone(ErrorMessage = "Geçersiz telefon numarası.")]
		public string? Phone { get; set; }

		public string? CardNumber { get; set; }

		public byte[]? ProfilePicture { get; set; }

		public int? EmployeeStatusId { get; set; }
		public EmployeeStatus EmployeeStatus { get; set; }

		[StringLength(11, MinimumLength = 11, ErrorMessage = "Kimlik kartı 11 haneli olmalıdır.")]
		public string? NationalId { get; set; }

		// İşe giriş ve işten çıkış tarihleri
		public DateTime? JobStartDate { get; set; }
		public DateTime? JobEndDate { get; set; }

		// Kullanıcı durumu (Aktif/Pasif)
		public bool? IsActive { get; set; }

		// Kayıt yaratma ve güncelleme bilgileri
		public DateTime? CreatedDate { get; set; }
		public string? CreatedBy { get; set; }
		public DateTime? UpdatedDate { get; set; }
		public string? UpdatedBy { get; set; }
	}
}
