using System.ComponentModel.DataAnnotations;

namespace GnuPlusLinuxDAL
{
    public class Class
    {
		[Key]
		public byte classId { get; set; }

		[Required]
		public string className { get; set; }
    }
}
