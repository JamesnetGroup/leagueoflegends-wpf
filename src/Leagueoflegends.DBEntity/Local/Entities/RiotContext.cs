using Leagueoflegends.DBEntity.Local.Entities.Schema;
using Microsoft.EntityFrameworkCore;

namespace Leagueoflegends.DBEntity.Local.Entities
{
	public class RiotContext : DbContext
	{
		public DbSet<Users> Users { get; set; }
		public DbSet<Friends> Friends { get; set; }
		public DbSet<CodeItem> CodeItems { get; set; }
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder
				.UseSqlServer("Data Source=SQL5101.site4now.net;Initial Catalog=db_a63c18_riot;User Id=riotadmin;Password=!Database2021");
		}
	}
}
