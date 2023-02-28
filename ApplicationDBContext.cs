using IGApi.Models;
using Microsoft.EntityFrameworkCore;

namespace IGApi
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext>options):base(options)
        {
        }

        public DbSet<CandidateModel> Candidates { get; set; }
        public DbSet<RolModel> Rol { get; set; }
    }
}
