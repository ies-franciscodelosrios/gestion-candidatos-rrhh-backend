using IGApi.Enums;
using IGApi.Dtos;
using IGApi.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace IGApi.NewFolder1
{
    public class CandidateDto
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public char Surname { get; set; }
        public string Description { get; set; }
        public string RejectionReason { get; set; }
        public CandidateStatusEnum Status { get; set; }
        public ContactMethodEnum Contact { get; set; }
        public DateTime CvDate { get; set; }
        public DateTime InterviewDate { get; set; }
        public DateTime HiringDate { get; set; }
        public DateTime FirstContactDate { get; set; }
        [ForeignKey("Rolid")]
        public RolDto? Rol { get; set; }

        public CandidateModel ParseToModel()
        {
            RolModel rolModel = null;
            if (Rol != null)
            {
                rolModel = Rol.ParseToModel();
            }
            return new RolModel
            {
                Id = Id,
                Name = Name,

            };
    }
    }

    
}
