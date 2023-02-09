using IGapi.Dtos;
using IGapi.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Migrations.Operations;

namespace IGapi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OfferController
    {
        private readonly OfferService offerService;
        private readonly Offer_ApplicationService offerApplicationService;

        public OfferController (OfferService offerService, Offer_ApplicationService offerApplicationService)
        {
            this.offerService = offerService;
            this.offerApplicationService = offerApplicationService;
        }

        [HttpGet("GetAll")]
        public List<OfferDto> GetAll()
        {
            return offerService.GetAll();
        }

        [HttpGet("Get/{id}")]
        public OfferDto Get(int id)
        {
            return offerService.GetById(id);
        }

        [HttpPost("Insert")]
        public bool Insert([FromBody]OfferDto offer)
        {
            if (offer.Offerings != null)
            {
                for (int i = 0; i < offer.Offerings.Count; i++)
                {
                    offerApplicationService.Insert(offer.Offerings[i], offer);
                }
            }
            return offerService.Insert(offer);
        }

        [HttpDelete("Delete/{id}")]
        public bool Delete(int id)
        {
            return offerService.Delete(id);
        }
    }
}
