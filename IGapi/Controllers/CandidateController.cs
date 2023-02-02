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

        [HttpGet(Name = "GetCandidates")]
        public List<CandidateModel> GetAll() 
        {
            return candidateServ.GetCandidates();
        }

        [HttpPost]
        public bool Insert([FromBody] CandidateDto candidate)
        {
            return candidateServ.Insert(candidate);
        }
    }
}
