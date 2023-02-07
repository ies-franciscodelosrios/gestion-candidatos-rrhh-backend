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

        public CandidateModel GetbyId(int id)
        {
            var aux = new CandidateModel();
            if(db.Candidates.FirstOrDefault(c => c.Id == id)!=null)
            {
                aux = db.Candidates.FirstOrDefault(c => c.Id == id);
            }
            return aux;

        }
    }
}
