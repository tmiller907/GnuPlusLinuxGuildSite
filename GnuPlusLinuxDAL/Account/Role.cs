using System.ComponentModel.DataAnnotations;

namespace GnuPlusLinuxDAL
{
    public class Role
    {
		[Key]
		public byte roleId { get; set; }

		[Required]
		public string roleName { get; set; }
    }
}
