using IGapi.Services;

namespace IGapi.Controllers
{
    public class AdminController
    {
        private readonly AdminService _adminService;

        public AdminController(AdminService adminService)
        {
            this._adminService = adminService;
        }
    }
}
