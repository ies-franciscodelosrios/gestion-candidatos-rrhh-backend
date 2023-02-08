using IGapi.Dtos;
using IGapi.Models;
using IGapi.Repositories;

namespace IGapi.Services
{
    public class CandidateService
    {
        private readonly CandidateRepository candidateRepo;

        public CandidateService(CandidateRepository candidateRepo)
        {
            this.candidateRepo = candidateRepo;
        }

        public List<CandidateDto> GetCandidates()
        { 
            return candidateRepo.GetCandidates().Select(C => C.ParseToDto()).ToList();
        }

        public bool Insert(CandidateDto candidate)
        {
            return candidateRepo.Insert(candidate.ParseToModel());
        }

        public bool Delete(int id)
        {
            return candidateRepo.Delete(id);
        }

        public CandidateDto GetCandidate(int id)
        {
            var aux = new List<CreateOffer_ApplicationDto>();
            aux = candidateRepo.GetListFromId(id).Select(c => c.ParseToCreateOfferApplication()).ToList();
            var candidate = candidateRepo.GetbyId(id).ParseToDto();
            candidate.Offerings = aux;
            return candidate;
        }
    }
}
