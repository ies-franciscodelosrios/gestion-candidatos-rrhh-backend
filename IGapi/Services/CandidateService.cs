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

        public List<CandidateModel> GetCandidates()
        {
            //List<CandidateDto> candidates = new List<CandidateDto>();
            //candidates = candidateRepo.GetCandidates().Select(C => C.ParseToDto()).ToList();
            //return candidates;
            return candidateRepo.GetCandidates();
        }

        public bool Insert(CandidateDto candidate)
        {
            return candidateRepo.Insert(candidate.ParseToModel());
        }


    }
}
