using Microsoft.EntityFrameworkCore;

namespace _CoreDepertmanWeb.Models
{
	public class Context:DbContext
	{
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer("server=.\\SQLEXPRESS;database=DepartmanDb; Trusted_Connection=True;TrustServerCertificate=True");
		}

		public DbSet<Departmanlar> Departmanlars { get; set; }

		public DbSet<Personel> Personels { get; set; }

	}
}
