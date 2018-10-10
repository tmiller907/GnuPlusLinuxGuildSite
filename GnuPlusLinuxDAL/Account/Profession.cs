using System.ComponentModel.DataAnnotations;

namespace GnuPlusLinuxDAL
{
    public class Profession
    {
		[Key]
		public byte ProfessionId { get; set; }

		[Required]
		public string ProfessionName { get; set; }
    }
}
