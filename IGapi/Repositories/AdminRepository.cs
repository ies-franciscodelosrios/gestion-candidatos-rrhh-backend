using IGapi.Context;

namespace IGapi.Repositories
{
    public class AdminRepository
    {
        private readonly ApplicationDBContext db;

        public AdminRepository(ApplicationDBContext db)
        {
            this.db = db;
        }
    }
}
