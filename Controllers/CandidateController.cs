using IGApi.Models;
using IGApi.NewFolder1;
using IGApi.Service;
using Microsoft.AspNetCore.Mvc;

namespace IGApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CandidateController
    {
        private readonly CandidateService _candidateService;

        public CandidateController(CandidateService candidateService)
        {
            _candidateService = candidateService;
        }

        [HttpGet("GetAll")]
        public Task<List<CandidateDto>> GetAll() 
        {
            return _candidateService.GetAll();
        }

        [HttpGet("GetById/{id}")]
        public Task<CandidateDto> Get(int id)
        {
            return _candidateService.Get(id);
        }

        [HttpDelete("Delete/{id}")]
        public Task<bool> Delete(int id)
        {
            return _candidateService.Delete(id);
        }

        [HttpPost("Insert")]
        public Task<bool> Insert([FromBody] CandidateModel candidate)
        {
            return _candidateService.Insert(candidate);
        }

        [HttpPut("Update")]
        public Task<bool> Update([FromBody]CandidateModel candidate) 
        {
            return _candidateService.Update(candidate);
        }
    }
}
