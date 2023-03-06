using IGApi.Models;
using Microsoft.EntityFrameworkCore;

namespace IGApi.Repository
{
    public class CandidateRepository
    {
        private readonly Repository<CandidateModel> _repository;

        public CandidateRepository(Repository<CandidateModel> repository)
        {
            _repository = repository;
        }

        public async Task<CandidateModel> Get(int id)
        {
            return await this._repository.AsQueryable().Include(x => x.Rol).FirstAsync(x => x.Id == id);
        }

        public async Task<List<CandidateModel>> GetAll()
        {
            return await _repository.GetAll();
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
