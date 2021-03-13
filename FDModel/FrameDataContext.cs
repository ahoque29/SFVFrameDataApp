using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace FDModel
{
	public class FrameDataContext : DbContext
	{
		public static FrameDataContext Instance { get; } = new FrameDataContext();

		public DbSet<Character> Characters { get; set; }
		public DbSet<Move> Moves { get; set; }

		protected override void OnConfiguring(DbContextOptionsBuilder options)
		{
			if (!options.IsConfigured)
			{
				options.UseSqlServer(@"Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = SFVFrameData;");
			}
		}
	}
}
