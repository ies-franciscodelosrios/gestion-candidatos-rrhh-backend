using IGapi.Context;
using IGapi.Dtos;
using IGapi.Models;

namespace IGapi.Repositories
{
    public class CandidateRepository
    {
        private readonly ApplicationDBContext db;

        public CandidateRepository(ApplicationDBContext db)
        {
            this.db = db;
        }

        public List<CandidateModel> GetCandidates()
        {
            return db.Candidates.ToList();
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
                }catch(Exception ex) {
                    return false;
                } 
            }
            return false;
        }
    }
}
