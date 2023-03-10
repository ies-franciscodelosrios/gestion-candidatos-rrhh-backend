using IGApi.Enums;
using IGApi.Dtos;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using IGApi.NewFolder1;

namespace IGApi.Models
{
    [Table("Rol")]
    public class RolModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Project { get; set; }
        public string Area { get; set; }
        public RolEnum Rol { get; set; }
        public SubRolEnum SubRol { get; set; }
        public LocalizationEnum Localization { get; set; }
        public string Description { get; set; }
        public RolStatusEnum Status { get; set; }
        public int Vacancies { get; set; }
        [DataType(DataType.Date)]
        public DateTime CreationDate { get; set; }
        [DataType(DataType.Date)]
        public DateTime CloseDate { get; set; }
        public virtual List<CandidateModel>? Candidates { get; set; }

        public RolDto ParseToDto(bool includes = false)
        {
            var candidates = new List<CandidateDto>();
            if (includes && this.Candidates != null)
            {
                candidates = this.Candidates.Select(x => x.ParseToDto()).ToList();
            }
            return new RolDto
            {
                Id = Id,
                Project = Project,
                Area = Area,
                Rol = Rol,
                SubRol = SubRol,
                Localization = Localization,
                Description = Description,
                Status = Status,
                Vacancies = Vacancies,
                CreationDate = CreationDate,
                CloseDate = CloseDate,
                Candidates = candidates
            };
        }
    }
    
}
