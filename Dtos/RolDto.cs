using IGApi.Enums;
using IGApi.Models;
using IGApi.NewFolder1;

namespace IGApi.Dtos
{
    public class RolDto
    {
        public int Id { get; set; }
        public string Project { get; set; }
        public string Area { get; set; }
        public RolEnum Rol { get; set; }
        public SubRolEnum SubRol { get; set; }
        public LocalizationEnum Localization { get; set; }
        public string Description { get; set; }
        public RolStatusEnum Status { get; set; }
        public int Vacancies { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime CloseDate { get; set; }
        public virtual List<CandidateDto>? Candidates { get; set; }

        public RolModel ParseToModel()
        {
            var candidates = new List<CandidateModel>();
            if(this.Candidates != null)
            {
                candidates = this.Candidates.Select(x => x.ParseToModel()).ToList();
            }
            return new RolModel
            {
                Id = this.Id,
                Project = this.Project,
                Area = this.Area,
                Rol = this.Rol,
                SubRol = this.SubRol,
                Localization = this.Localization,
                Description = this.Description,
                Status = this.Status,
                Vacancies = this.Vacancies,
                CreationDate = this.CreationDate,
                CloseDate = this.CloseDate,
                Candidates = candidates
            };
        }
    }
}
