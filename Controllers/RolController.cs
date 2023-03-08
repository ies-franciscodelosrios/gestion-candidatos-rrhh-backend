using IGApi.Dtos;
using IGApi.Models;
using IGApi.Service;
using Microsoft.AspNetCore.Mvc;

namespace IGApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RolController
    {
        private readonly RolService _rolService;

        public RolController(RolService RolService)
        {
            _rolService = RolService;
        }

        [HttpGet("GetAll")]
        public Task<List<RolDto>> GetAll()
        {
            return _rolService.GetAll();
        }

        [HttpGet("GetById/{id}")]
        public Task<RolDto> Get(int id)
        {
            return _rolService.Get(id);
        }

        [HttpDelete("Delete/{id}")]
        public Task<bool> Delete(int id)
        {
            return _rolService.Delete(id);
        }

        [HttpPost("Insert")]
        public Task<bool> Insert([FromBody] RolModel rol)
        {
            Console.WriteLine(rol.CreationDate);
            return _rolService.Insert(rol);
        }

        [HttpPut("Update")]
        public async Task<bool> Update([FromBody] RolModel rol)
        {
            return await _rolService.Update(rol);
        }
    }
}
