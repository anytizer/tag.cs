using configurations;
using libraries.models;
using Microsoft.EntityFrameworkCore;

namespace libraries
{
    public class TaggerContext: DbContext
    {
        public DbSet<ImageModel> images { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string dbfile = Configs.DATABASE;
            if (!File.Exists(dbfile))
            {
                throw new Exception($"First, install the database ({dbfile})!");
            }
            else
            {
                dbfile = new FileInfo(dbfile).FullName;
            }

            optionsBuilder.UseSqlite($"Data Source=\"{dbfile}\"");
        }
    }
}
