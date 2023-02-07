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
            List<CandidateDto> candidates = new List<CandidateDto>();
            candidates = candidateRepo.GetCandidates().Select(C => C.ParseToDto()).ToList();
            return candidates;
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
            return candidateRepo.GetbyId(id).ParseToDto();
        }


    }
}
