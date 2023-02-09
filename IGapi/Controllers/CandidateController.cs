using IGapi.Dtos;
using IGapi.Models;
using IGapi.Services;
using Microsoft.AspNetCore.Mvc;

namespace IGapi.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class CandidateController : ControllerBase
    {

        private readonly CandidateService candidateServ;
        private readonly Offer_ApplicationService offerServ;

        public CandidateController(CandidateService candidateServ, Offer_ApplicationService offerServ)
        {
            this.candidateServ = candidateServ;
            this.offerServ = offerServ;
        }

        [HttpGet("GetAll")]
        public List<CandidateDto> GetAll() 
        {
            return candidateServ.GetCandidates();
        }

        [HttpGet("GetById/{id}")]
        public CandidateDto GetCandidate(int id)
        {
            return candidateServ.GetCandidate(id);
        }

        [HttpPost("Insert")]
        public bool Insert([FromBody] CandidateDto candidate)
        {
            if(candidate.Offerings!= null)
            {
                for(int i=0; i<candidate.Offerings.Count; i++)
                {
                    offerServ.Insert(candidate.Offerings[i],candidate);
                }
            }
            return candidateServ.Insert(candidate);
        }

        [HttpDelete("Delete/{id}")]
        public bool Delete(int id)
        {
            return candidateServ.Delete(id);
        }


    }
}
