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
        public string? Description { get; set; }
        [DefaultValue("false")]
        public bool IsAccepted { get; set; }
        [ForeignKey("Id_Candidate")]
        public virtual CandidateModel? Candidate { get; set; }
        [ForeignKey("id_Oferta")]
        public virtual OfferModel? Offer { get; set; }


        public Offer_ApplicationDto ParseToDto()
        {
            return new Offer_ApplicationDto()
            {
                Id = Id,
                Entry_Date = Entry_Date,
                Assignment_Date = Assignment_Date,
                Description= Description,
                IsAccepted = IsAccepted,
                Candidate=Candidate != null ? Candidate.ParseToDto() : null,
                Offer=Offer != null ? Offer.ParseToDto() : null
            };
        }
        public CreateOffer_ApplicationDto ParseToCreateOfferApplication()
        {
            return new CreateOffer_ApplicationDto
            {
                Id = Id,
                Entry_Date = Entry_Date,
                Assignment_Date = Assignment_Date,
                Description= Description,
                IsAccepted = IsAccepted,
                Candidate_id = Candidate != null ? Candidate.Id : null,
                Offer_id = Offer.Id

            };
        }
    }
}
