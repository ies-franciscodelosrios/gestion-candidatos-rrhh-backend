using IGApi.Models;
using IGApi.Repository;

namespace IGApi.Service
{
    public class CandidateService
    {
        private readonly CandidateRepository repository;

        public CandidateService(CandidateRepository repository)
        {
            this.repository = repository;
        }

        public List<CandidateModel> GetAll() 
        {
            return repository.GetAll();
        }

        public CandidateModel Get(int id)
        {
            return repository.Get(id);
        }

        public bool Insert(CandidateModel candidate)
        {
            return repository.Insert(candidate);
        }

        public bool Delete(int id)
        {
            return repository.Delete(id);
        }
    }
}
