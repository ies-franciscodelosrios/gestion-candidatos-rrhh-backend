using IGApi.Models;
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
        public List<CandidateModel> GetAll() 
        {
            return _candidateService.GetAll();
        }

        [HttpGet("GetById/{id}")]
        public CandidateModel Get(int id)
        {
            return _candidateService.Get(id);
        }

        [HttpDelete("Delete/{id}")]
        public bool Delete(int id)
        {
            return _candidateService.Delete(id);
        }

        [HttpPost("Insert")]
        public bool Insert([FromBody] CandidateModel candidate)
        {
            return _candidateService.Insert(candidate);
        }
    }
}
