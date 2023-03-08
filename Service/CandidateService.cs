using IGApi.Models;
using IGApi.Dtos;
using IGApi.Repository;
using IGApi.NewFolder1;

namespace IGApi.Service
{
    public class CandidateService
    {
        private readonly CandidateRepository _repository;

        public CandidateService(CandidateRepository repository)
        {
            this._repository = repository;
        }

        public async Task<List<CandidateDto>> GetAll() 
        {
            return (await _repository.GetAll()).Select(x => x.ParseToDto(true)).ToList();
        }

        public async Task<CandidateDto> Get(int id)
        {
           return (await this._repository.Get(id)).ParseToDto(true);
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
