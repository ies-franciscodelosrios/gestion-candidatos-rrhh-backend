using IGapi.Context;
using IGapi.Dtos;
using IGapi.Models;
using IGapi.Repositories;

namespace IGapi.Services
{
    public class Offer_ApplicationService
    {
        private readonly Offer_ApplicationRepository offer_applicationRepo;
        private readonly OfferRepository offerRepository;
        private readonly CandidateRepository candidateRepository;
        private readonly ApplicationDBContext db;

        public Offer_ApplicationService(Offer_ApplicationRepository offer_applicationRepo, CandidateRepository candidateRepository, OfferRepository offerRepository, ApplicationDBContext applicationDB)
        {
            this.offer_applicationRepo = offer_applicationRepo;
            this.candidateRepository = candidateRepository;
            this.offerRepository = offerRepository;
            db = applicationDB;
        }

        public bool Insert(CreateOffer_ApplicationDto offer_Application)
        {
            if(offer_Application != null)
            {
                var aux = new Offer_ApplicationModel()
                {
                    Assignment_Date =   offer_Application.Assignment_Date,
                    Description =       offer_Application.Description,
                    Entry_Date =        offer_Application.Entry_Date,
                    IsAccepted =        offer_Application.IsAccepted,
                    Candidate =         db.Candidates.FirstOrDefault(c => c.Id == offer_Application.Candidate_id),//candidateRepository.GetbyId((int)offer_Application.Candidate_id),
                    Offer =             offerRepository.GetById(offer_Application.Offer_id) 
                };
                return offer_applicationRepo.Insert(aux);
            }
            return false;
            
        }

        public bool Delete(int id)
        {
            return offer_applicationRepo.Delete(id);
        }

        public List<Offer_ApplicationDto> GetAll()
        {
            return offer_applicationRepo.GetAll().Select(o => o.ParseToDto()).ToList();
        }

        public Offer_ApplicationDto GetById(int id)
        {
            return offer_applicationRepo.GetById(id).ParseToDto();
        }

        public bool Insert(CreateOffer_ApplicationDto offer_Application,CandidateDto candidate)
        {
            if (offer_Application != null)
            {
                var aux = new Offer_ApplicationModel()
                {
                    Assignment_Date = offer_Application.Assignment_Date,
                    Description = offer_Application.Description,
                    Entry_Date = offer_Application.Entry_Date,
                    IsAccepted = offer_Application.IsAccepted,
                    Candidate = candidate.ParseToModel(),//candidateRepository.GetbyId((int)offer_Application.Candidate_id),
                    Offer = offerRepository.GetById(offer_Application.Offer_id)
                };
                return offer_applicationRepo.Insert(aux);
            }
            return false;

        }
        public bool Insert(CreateOffer_ApplicationDto offer_Application, OfferDto offer)
        {
            if (offer_Application != null)
            {
                var aux = new Offer_ApplicationModel()
                {
                    Assignment_Date = offer_Application.Assignment_Date,
                    Description = offer_Application.Description,
                    Entry_Date = offer_Application.Entry_Date,
                    IsAccepted = offer_Application.IsAccepted,
                    Candidate = candidateRepository.GetbyId((int)offer_Application.Candidate_id),
                    Offer = offer.ParseToModel()
                };
                return offer_applicationRepo.Insert(aux);
            }
            return false;

        }
    }
}
