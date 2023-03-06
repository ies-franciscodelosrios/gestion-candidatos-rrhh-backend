using IGApi.Models;
using IGApi.Repository;

namespace IGApi.Service
{
    public class CandidateService
    {
        private readonly CandidateRepository _repository;

        public CandidateService(CandidateRepository repository)
        {
            this._repository = repository;
        }

        public async Task<List<CandidateModel>> GetAll() 
        {
            return await _repository.GetAll();
        }

        public async Task<CandidateModel> Get(int id)
        {
           return await this._repository.Get(id);
        }

        public async Task<bool> Insert(CandidateModel candidate)
        {
            return await _repository.Insert(candidate);
        }

        public async Task<bool> Delete(int id)
        {
            return await _repository.Delete(id);
        }

        public async Task<bool> Update(CandidateModel candidate)
        {
            return await _repository.Update(candidate);
        }
    }
}
