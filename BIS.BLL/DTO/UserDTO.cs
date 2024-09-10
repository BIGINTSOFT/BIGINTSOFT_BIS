using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BIS.BLL.DTO
{
	public class UserDTO
	{
		public int Id { get; set; }
		public string UserName { get; set; }
		public string UserSurname { get; set; }
		public string? Email { get; set; }
		public string? Phone { get; set; }
		public byte[]? ProfilePicture { get; set; }
		public int EmployeeStatusId { get; set; }
		public string EmployeeStatus { get; set; }  // Sadece StatusName alanını taşır
		public bool? IsActive { get; set; }
		public DateTime? CreatedDate { get; set; }
		public string? NationalId { get; set; }
	}

}
