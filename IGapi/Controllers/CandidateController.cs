using IGapi.Dtos;
using IGapi.Models;
using IGapi.Services;
using Microsoft.AspNetCore.Mvc;

namespace IGapi.Controllers
{

    [ApiController]
    [Route("Candidates")]
    public class CandidateController : ControllerBase
    {

        private readonly CandidateService candidateServ;

        public CandidateController(CandidateService candidateServ)
        {
            this.candidateServ = candidateServ;
        }

        [HttpGet("GetAll")]
        public List<CandidateDto> GetAll() 
        {
            return candidateServ.GetCandidates();
        }

        [HttpPost("Insert")]
        public bool Insert([FromBody] CandidateDto candidate)
        {
            return candidateServ.Insert(candidate);
        }
    }
}
