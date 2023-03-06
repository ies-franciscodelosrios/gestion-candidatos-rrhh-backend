using IGApi.Models;
using IGApi.Repository;

namespace IGApi.Service
{
    public class RolService
    {
        private readonly Repository<RolModel> _repository;

        public RolService(Repository<RolModel> rolRepository)
        {
            this._repository = rolRepository;
        }

        public Task<List<RolModel>> GetAll()
        {
            return this._repository.GetAll();
        }

        public Task<RolModel> Get(int id)
        {
            return this._repository.Get(id);
        }

        public Task<bool> Insert(RolModel model)
        {
            return this._repository.Insert(model);
        }

        public Task<bool> Delete(int id)
        {
            return this._repository.Delete(id);
        }

        public async Task<RolModel> Update(RolModel rol)
        {
            return await this._repository.Update(rol);
        } 
    }
}
