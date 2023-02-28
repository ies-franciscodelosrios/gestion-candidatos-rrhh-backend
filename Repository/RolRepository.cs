using IGApi.Models;

namespace IGApi.Repository
{
    public class RolRepository
    {
        private readonly ApplicationDBContext db;

        public RolRepository(ApplicationDBContext db)
        {
            this.db = db;
        }

        public List<RolModel> GetAll()
        {
            return this.db.Rol.ToList();
        }

        public RolModel Get(int id)
        {
            return db.Rol.FirstOrDefault(r => r.Id == id);
        }

        public bool Insert(RolModel rol)
        {
            if (rol != null)
            {
                try
                {
                    db.Rol.Add(rol);
                    db.SaveChanges();
                    return true;
                }
                catch (Exception ex)
                {
                    return false;
                }
            }
            return false;
        }
        public bool Delete(int id)
        {
            if (db.Rol.FirstOrDefault(c => c.Id == id) != null)
            {
                try
                {
                    db.Rol.Remove(db.Rol.FirstOrDefault(c => c.Id == id));
                    db.SaveChanges();
                    return true;
                }
                catch
                {
                    return false;
                }
            }
            return false;
        }
    }
}
