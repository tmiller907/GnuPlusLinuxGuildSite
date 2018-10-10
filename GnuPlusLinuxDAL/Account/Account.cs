using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GnuPlusLinuxDAL
{
    public class Account
    {
		[Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int AccountId { get; set; }

		[Required]
		public string Username { get; set; }

		[Required]
		public string Password { get; set; }

		[Compare("Password", ErrorMessage = "Passwords do not match")]
		public string ConfirmPw { get; set; }

		[Required]
		public string Email { get; set; }

		[Required, DatabaseGenerated(DatabaseGeneratedOption.Computed)]
		public DateTime DateJoined { get; set; }

		[Required]
		public bool IsAdmin { get; set; }

		[Required]
		public bool   IsMod        { get; set; }

		// Toon Specific Information
		public string ToonName    { get; set; }
		public byte   Class       { get; set; }
		public byte   Role        { get; set; }
		public byte   Profession1 { get; set; }
		public byte   Profession2 { get; set; }
	}
}
