using IGapi.Models;
using System.ComponentModel;

namespace IGapi.Dtos
{
    public class Offer_ApplicationDto
    {
        public int Id { get; set; }
        public DateTime Entry_Date { get; set; }
        public DateTime Assignment_Date { get; set; }
        public IFormFile? Technical_Test { get; set; }
        public string? Description { get; set; }
        [DefaultValue("false")]
        public bool IsAccepted { get; set; }
        public int? Id_Candidate { get; set; }
        public virtual CandidateDto? Candidate { get; set; }
        public int? Id_Oferta { get; set; }
        public virtual OfferDto? Offer { get; set; }


    }
}
