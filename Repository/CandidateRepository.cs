using IGApi.Models;

namespace IGApi.Repository
{
    public class CandidateRepository
    {
        private readonly ApplicationDBContext db;

        public CandidateRepository (ApplicationDBContext db)
        {
            this.db = db;
        }
        
        public List<CandidateModel> GetAll()
        {
           return this.db.Candidates.ToList();
        }

        public CandidateModel Get(int id)
        {
            return db.Candidates.FirstOrDefault(c => c.Id == id);
        }

        public bool Insert(CandidateModel candidate)
        {
            if (candidate != null)
            {
                try
                {
                    db.Candidates.Add(candidate);
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
            if (db.Candidates.FirstOrDefault(c => c.Id == id) != null)
            {
                try
                {
                    db.Candidates.Remove(db.Candidates.FirstOrDefault(c => c.Id == id));
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
