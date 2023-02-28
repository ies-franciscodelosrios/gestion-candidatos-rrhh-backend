using IGApi.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IGApi.Models
{
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
        public DateTime CreationDate { get; set; }
        public DateTime CloseDate { get; set; }
        public List<CandidateModel> Candidates { get; set; }
    }
}
