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

        public bool Insert(OfferDto offer)
        {
            return offerRepo.Insert(offer.ParseToModel());
        }

        public List<OfferDto> GetAll()
        {
            List<OfferDto> candidates = new List<OfferDto>();
            candidates = offerRepo.GetAll().Select(C => C.ParseToDto()).ToList();
            return candidates;
        }

        public bool Delete(int id) 
        {
            return offerRepo.Delete(id);
        }

        public OfferDto GetById(int id)
        {
            return offerRepo.GetById(id).ParseToDto();
        } 
    }
}
