using IGApi.Models;
using IGApi.Dtos;
using Microsoft.EntityFrameworkCore;

namespace IGApi.Repository
{
    public class RolRepository
    {
        private readonly Repository<RolModel> _repository;

        public RolRepository(Repository<RolModel> repository)
        {
            _repository = repository;
        }


        public async Task<RolModel> Get(int id)
        {
            return await _repository.AsQueryable().Include(x => x.Candidates).FirstAsync(x => x.Id == id);
        }

        public async Task<List<RolModel>> GetAll()
        {
            return _repository.AsQueryable().Include(x => x.Candidates).ToList();
        }

        public async Task<bool> Insert(RolModel rol)
        {
            return await _repository.Insert(rol);
        }

        public async Task<bool> Delete(int id)
        {
            return await _repository.Delete(id);
        }

        public async Task<bool> Update(RolModel rol)
        {
            return await _repository.Update(rol);
        }
    }
}
