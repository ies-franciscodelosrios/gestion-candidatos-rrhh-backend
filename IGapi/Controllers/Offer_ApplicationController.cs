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

        [HttpPost]
        public bool Insert([FromForm]Offer_ApplicationDto offer_ApplicationDto)
        {
            return offer_ApplicationSer.Insert(offer_ApplicationDto);
        }
    }
}
