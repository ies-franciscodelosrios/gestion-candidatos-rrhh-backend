using IGapi.Dtos;
using IGapi.Services;
using Microsoft.AspNetCore.Mvc;

namespace IGapi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class Offer_ApplicationController
    {
        private readonly Offer_ApplicationService offer_ApplicationSer;

        public Offer_ApplicationController(Offer_ApplicationService offer_ApplicationSer)
        {
            this.offer_ApplicationSer = offer_ApplicationSer;
        }

        [HttpPost("Insert")]
        public bool Insert([FromBody]CreateOffer_ApplicationDto offer_ApplicationDto)
        {
            return offer_ApplicationSer.Insert(offer_ApplicationDto);
        }

        [HttpDelete("Delete/{id}")]
        public bool Delete(int id)
        {
            return offer_ApplicationSer.Delete(id);
        }

        [HttpGet("Get/{id}")]
        public Offer_ApplicationDto Get(int id)
        {
            return offer_ApplicationSer.GetById(id);
        }

        [HttpGet("GetAll")]
        public List<Offer_ApplicationDto> GetAll()
        {
            return offer_ApplicationSer.GetAll();
        }
    }
}
