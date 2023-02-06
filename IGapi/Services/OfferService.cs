using IGapi.Dtos;
using IGapi.Repositories;

namespace IGapi.Services
{
    public class OfferService
    {

        private readonly OfferRepository offerRepo;

        public OfferService(OfferRepository offerRepo)
        {
            this.offerRepo = offerRepo;
        }

        //public bool Insert(OfferDto offer)
        //{
        //    return offerRepo.Insert(offer);
        //}
    }
}
