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

			if (context.accounts.Any()) {
				return;
			}
			else {
				context.accounts.Add(SuperAdmin());
				AllClasses().ForEach(c => context.classes.Add(c));
				AllRoles().ForEach(r => context.roles.Add(r));
				AllProfessions().ForEach(p => context.professions.Add(p));

				context.SaveChanges();
			}
		}

		private static Account SuperAdmin() 
		{
			return new Account {
				username = "SA",
				password = "TestAdmin",
				confirmPw = "TestAdmin",
				email = "test@gmail.com",
				isAdmin = true,
				isMod = true,
			};
		}

		private static List<Class> AllClasses() 
		{
			return new List<Class> {
				new Class { classId = 1, className = "Druid" },
				new Class { classId = 2, className = "Hunter" },
				new Class { classId = 3, className = "Mage" },
				new Class { classId = 4, className = "Paladin" },
				new Class { classId = 5, className = "Priest" },
				new Class { classId = 6, className = "Rogue" },
				new Class { classId = 7, className = "Shaman" },
				new Class { classId = 8, className = "Warlock" },
				new Class { classId = 9, className = "Warrior" }
			};
		}

		private static List<Role> AllRoles() 
		{
			return new List<Role> {
				new Role { roleId = 1, roleName = "Tank" },
				new Role { roleId = 2, roleName = "Healer" },
				new Role { roleId = 3, roleName = "DPS" }
			};
		}

		private static List<Profession> AllProfessions() 
		{
			return new List<Profession> {
				new Profession { professionId = 1,
					professionName = "Herbalism" },

				new Profession { professionId = 2,
					professionName = "Mining" },
				
				new Profession { professionId = 3,
					professionName = "Skinning" },

				new Profession { professionId = 4,
					professionName = "Alchemy" },
				
				new Profession { professionId = 5,
					professionName = "Blacksmithing" },
				
				new Profession { professionId = 6,
					professionName = "Enchanting" },

				new Profession { professionId = 7,
					professionName = "Engineering" },

				new Profession { professionId = 8,
					professionName = "Leatherworking" },

				new Profession { professionId = 9,
					professionName = "Tailoring" }
			};
		}
    }
}
