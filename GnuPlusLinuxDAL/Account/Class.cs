using System.ComponentModel.DataAnnotations;

namespace GnuPlusLinuxDAL
{
    public class Class
    {
		[Key]
		public byte ClassId { get; set; }

		[Required]
		public string ClassName { get; set; }
    }
}
