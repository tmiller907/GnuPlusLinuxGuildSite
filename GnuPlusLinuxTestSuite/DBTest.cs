using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Configuration.Json;
using Xunit;

using GnuPlusLinuxDAL;

namespace GnuPlusLinuxTestSuite
{
    public class DBTest
    {
		private static AccountContext _accountContext;

		static DBTest() 
		{
			IConfiguration config = new ConfigurationBuilder().Build();

			// Just use localDB for testing
			string connectionString = 
				"Server=(localdb)\\mssqllocaldb;Database=GNUPlusLinux;" +
				"Trusted_Connection=True;MultipleActiveResultSets=true";

			DbContextOptions<AccountContext> DbContextOptions = 
				new DbContextOptionsBuilder<AccountContext>()
					.UseSqlServer(connectionString)
					.Options;

			_accountContext = new AccountContext(DbContextOptions);
		}

		[Fact]
		public void DatabaseIsSqlServer() 
		{
			Assert.True(_accountContext.Database.IsSqlServer());
		}
    }
}
