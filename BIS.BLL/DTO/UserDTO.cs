using BIS.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BIS.BLL.DTO
{
	public class UserDTO:User
	{
		public string EmployeeStatus { get; set; }  // Sadece StatusName alanını taşır
	}

}
