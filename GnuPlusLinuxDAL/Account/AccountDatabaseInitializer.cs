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
				new Class { ClassName = "Druid" },
				new Class { ClassName = "Hunter" },
				new Class { ClassName = "Mage" },
				new Class { ClassName = "Paladin" },
				new Class { ClassName = "Priest" },
				new Class { ClassName = "Rogue" },
				new Class { ClassName = "Shaman" },
				new Class { ClassName = "Warlock" },
				new Class { ClassName = "Warrior" }
			};
		}

		private static List<Role> AllRoles() 
		{
			return new List<Role> {
				new Role { RoleName = "Tank" },
				new Role { RoleName = "Healer" },
				new Role { RoleName = "DPS" }
			};
		}

		private static List<Profession> AllProfessions() 
		{
			return new List<Profession> {
				new Profession { ProfessionName = "Herbalism" },
				new Profession { ProfessionName = "Mining" },
				new Profession { ProfessionName = "Skinning" },
				new Profession { ProfessionName = "Alchemy" },
				new Profession { ProfessionName = "Blacksmithing" },
				new Profession { ProfessionName = "Enchanting" },
				new Profession { ProfessionName = "Engineering" },
				new Profession { ProfessionName = "Leatherworking" },
				new Profession { ProfessionName = "Tailoring" }
			};
		}
    }
}
