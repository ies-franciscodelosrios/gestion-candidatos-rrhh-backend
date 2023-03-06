using IGApi.Models;
using IGApi.Repository;

namespace IGApi.Service
{
    public class RolService
    {
        private readonly RolRepository _repository;

        public RolService(RolRepository rolRepository)
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

        public async Task<bool> Update(RolModel rol)
        {
            return await this._repository.Update(rol);
        } 
    }
}
