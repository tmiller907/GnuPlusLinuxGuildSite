using System.ComponentModel.DataAnnotations;

namespace GnuPlusLinuxDAL
{
    public class Profession
    {
		[Key]
		public byte professionId { get; set; }

		[Required]
		public string professionName { get; set; }
    }
}
