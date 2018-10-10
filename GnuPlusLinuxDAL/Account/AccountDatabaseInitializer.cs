using System.Collections.Generic;
using System.Linq;

namespace GnuPlusLinuxDAL
{
    public class AccountDatabaseInitializer
    {
		public static void Seed(AccountContext context) 
		{
			context.Database.EnsureCreated();

			// ---------------------------------------------------------------
			// If there are any accounts on the database, then skip seeding;
			// otherwise, create a SA account and add static data
			// ---------------------------------------------------------------

			if (context.Accounts.Any()) {
				return;
			}
			else {
				context.Accounts.Add(SuperAdmin());
				AllClasses().ForEach(c => context.Classes.Add(c));
				AllRoles().ForEach(r => context.Roles.Add(r));
				AllProfessions().ForEach(p => context.Professions.Add(p));

				context.SaveChanges();
			}
		}

		private static Account SuperAdmin() 
		{
			return new Account {
				Username = "SA",
				Password = "TestAdmin",
				ConfirmPw = "TestAdmin",
				Email = "test@gmail.com",
				IsAdmin = true,
				IsMod = true,
			};
		}

		private static List<Class> AllClasses() 
		{
			return new List<Class> {
				new Class { ClassId = 1, ClassName = "Druid" },
				new Class { ClassId = 2, ClassName = "Hunter" },
				new Class { ClassId = 3, ClassName = "Mage" },
				new Class { ClassId = 4, ClassName = "Paladin" },
				new Class { ClassId = 5, ClassName = "Priest" },
				new Class { ClassId = 6, ClassName = "Rogue" },
				new Class { ClassId = 7, ClassName = "Shaman" },
				new Class { ClassId = 8, ClassName = "Warlock" },
				new Class { ClassId = 9, ClassName = "Warrior" }
			};
		}

		private static List<Role> AllRoles() 
		{
			return new List<Role> {
				new Role { RoleId = 1, RoleName = "Tank" },
				new Role { RoleId = 2, RoleName = "Healer" },
				new Role { RoleId = 3, RoleName = "DPS" }
			};
		}

		private static List<Profession> AllProfessions() 
		{
			return new List<Profession> {
				new Profession { ProfessionId = 1,
					ProfessionName = "Herbalism" },

				new Profession { ProfessionId = 2,
					ProfessionName = "Mining" },

				new Profession { ProfessionId = 3,
					ProfessionName = "Skinning" },

				new Profession { ProfessionId = 4,
					ProfessionName = "Alchemy" },

				new Profession { ProfessionId = 5,
					ProfessionName = "Blacksmithing" },

				new Profession { ProfessionId = 6,
					ProfessionName = "Enchanting" },

				new Profession { ProfessionId = 7,
					ProfessionName = "Engineering" },

				new Profession { ProfessionId = 8,
					ProfessionName = "Leatherworking" },

				new Profession { ProfessionId = 9,
					ProfessionName = "Tailoring" }
			};
		}
    }
}
