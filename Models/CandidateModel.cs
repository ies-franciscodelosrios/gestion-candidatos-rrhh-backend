using IGApi.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IGApi.Models
{
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
        public RolModel Rol { get; set; }
    }
}
