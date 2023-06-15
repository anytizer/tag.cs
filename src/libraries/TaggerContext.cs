using Microsoft.EntityFrameworkCore;

namespace libraries
{
    public class TaggerContext: DbContext
    {
        public DbSet<ImageModel> images { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string dbfile = "tags.db";
            if(!File.Exists(dbfile))
            {
                throw new Exception("Install database first.");
            }
            else
            {
                dbfile = new FileInfo(dbfile).FullName;
            }

            optionsBuilder.UseSqlite($"Data Source=\"{dbfile}\"");
        }
    }
}
