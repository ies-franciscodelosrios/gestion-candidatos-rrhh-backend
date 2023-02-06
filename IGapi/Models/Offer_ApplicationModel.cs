using IGapi.Dtos;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IGapi.Models
{
    [Table("Offer_Application")]
    public class Offer_ApplicationModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public DateTime Entry_Date { get; set; }
        public DateTime Assignment_Date { get; set; }
        public byte[]? Technical_Test { get; set; }
        public string? Description { get; set; }
        [DefaultValue("false")]
        public bool IsAccepted { get; set; }
        [ForeignKey("Id_Candidate")]
        public int Id_Candidate { get; set; }
        public virtual CandidateModel Candidate { get; set; }
        [ForeignKey("id_Oferta")]
        public int Id_Oferta { get; set; }
        public virtual OfferModel Offer { get; set; }


        public Offer_ApplicationDto ParseToDto()
        {
            return new Offer_ApplicationDto()
            {
                Id = Id_Candidate,
                Entry_Date = Entry_Date,
                Assignment_Date = Assignment_Date,
                Description= Description,
                IsAccepted = IsAccepted,
                Id_Candidate = Id_Candidate,
                Id_Oferta= Id_Oferta,
                Candidate=Candidate.ParseToDto(),
                Offer=Offer.ParseToDto(),
            };
        }
    }
}
