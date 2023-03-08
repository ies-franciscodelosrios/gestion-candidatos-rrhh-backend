using IGApi.Models;
using IGApi.Dtos;
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

        public async Task<List<RolDto>> GetAll()
        {
            return (await this._repository.GetAll()).Select(x => x.ParseToDto(true)).ToList();
        }

        public async Task<RolDto> Get(int id)
        {
            return (await _repository.Get(id)).ParseToDto(true);
        }

        public async Task<bool> Insert(RolModel model)
        {
            return await _repository.Insert(model);
        }

        public async Task<bool> Delete(int id)
        {
            return await _repository.Delete(id);
        }

        public async Task<bool> Update(RolModel rol)
        {
            return await this._repository.Update(rol);
        } 
    }
}
