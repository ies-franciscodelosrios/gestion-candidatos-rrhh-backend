using IGApi.Models;
using IGApi.Repository;

namespace IGApi.Service
{
    public class RolService
    {
        private readonly RolRepository rolRepository;

        public RolService(RolRepository rolRepository)
        {
            this.rolRepository = rolRepository;
        }

        public List<RolModel> GetAll()
        {
            return this.rolRepository.GetAll();
        }

        public RolModel Get(int id)
        {
            return this.rolRepository.Get(id);
        }

        public bool Insert(RolModel model)
        {
            return this.rolRepository.Insert(model);
        }

        public bool Delete(int id)
        {
            return this.rolRepository.Delete(id);
        }
    }
}
