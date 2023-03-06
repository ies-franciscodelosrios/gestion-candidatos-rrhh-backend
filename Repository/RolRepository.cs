using IGApi.Models;

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
            return await this._repository.Get(id);
        }

        public async Task<List<RolModel>> GetAll()
        {
            return await _repository.GetAll();
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
