using IGApi.Dtos;
using IGApi.Enums;
using IGApi.NewFolder1;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IGApi.Models
{
    [Table("Candidato")]
    public class CandidateModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
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
        [ForeignKey("Rol")]
        public int Rolid { get; set; }
        public virtual RolModel? Rol { get; set; }

        public CandidateDto ParseToDto(bool includes = false)
        {
            RolDto roldto = null;
            if (includes && Rol != null)
            {
                 roldto = Rol.ParseToDto();
            }
            return new CandidateDto
            {
                Id = Id,
                Name = Name,
                Surname = Surname,
                Description = Description,
                RejectionReason = RejectionReason,
                Status = Status,
                Contact = Contact,
                CvDate = CvDate,
                InterviewDate = InterviewDate,
                HiringDate = HiringDate,
                FirstContactDate = FirstContactDate,
                Rol = roldto
            };
        }
    }

}
