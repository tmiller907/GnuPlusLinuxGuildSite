using Microsoft.EntityFrameworkCore;

namespace GnuPlusLinuxDAL
{
	public partial class AccountContext : DbContext 
	{
		public virtual DbSet<Account>    accounts    { get; set; }
		public virtual DbSet<Class>      classes     { get; set; }
		public virtual DbSet<Role>       roles       { get; set; }
		public virtual DbSet<Profession> professions { get; set; }

		public AccountContext(DbContextOptions<AccountContext> options) : 
			base(options) 
		{ }

		protected override void OnModelCreating(ModelBuilder modelBuilder) 
		{
			modelBuilder.Entity<Account>(acc => {
				acc.Property(x => x.accountId).ValueGeneratedOnAdd();
				acc.Property(x => x.username).IsRequired();
				acc.Property(x => x.dateJoined).HasDefaultValueSql("GETDATE()");
			});
		}
    }
}
