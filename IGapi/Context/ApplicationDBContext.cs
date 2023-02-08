using IGapi.Models;
using Microsoft.EntityFrameworkCore;

namespace IGapi.Context
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext>options):base(options) 
        {          
        }

        public DbSet<CandidateModel> Candidates { get; set; }
        public DbSet<AdminModel> Admins { get; set; }
        public DbSet<OfferModel> OfertasdeTrabajo { get; set; }
        public DbSet<Offer_ApplicationModel> Orders { get; set; }
    }
}
