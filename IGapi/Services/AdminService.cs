using IGapi.Repositories;

namespace IGapi.Services
{
    public class AdminService
    {
        private readonly AdminRepository _adminRepo;
        public AdminService(AdminRepository adminRepo)
        {
            this._adminRepo = adminRepo;
        }
    }
}
