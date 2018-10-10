using Microsoft.EntityFrameworkCore;

namespace GnuPlusLinuxDAL
{
	public partial class AccountContext : DbContext 
	{
		public virtual DbSet<Account>    Accounts    { get; set; }
		public virtual DbSet<Class>      Classes     { get; set; }
		public virtual DbSet<Role>       Roles       { get; set; }
		public virtual DbSet<Profession> Professions { get; set; }

		public AccountContext(DbContextOptions<AccountContext> options) : 
			base(options) 
		{ }

		protected override void OnModelCreating(ModelBuilder modelBuilder) 
		{
			modelBuilder.Entity<Account>(acc => {
				acc.Property(x => x.AccountId).ValueGeneratedOnAdd();
				acc.Property(x => x.Username).IsRequired();
				acc.Property(x => x.DateJoined).HasDefaultValueSql("GETDATE()");
			});
		}
    }
}
