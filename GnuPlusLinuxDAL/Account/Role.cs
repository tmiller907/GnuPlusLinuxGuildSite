using System.ComponentModel.DataAnnotations;

namespace GnuPlusLinuxDAL
{
    public class Role
    {
		[Key]
		public int RoleId { get; set; }

		[Required]
		public string RoleName { get; set; }
    }
}
