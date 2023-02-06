using IGapi.Models;

namespace IGapi.Dtos
{
    public class OfferDto
    {
        public int Id { get; set; }
        public string Tittle { get; set; }
        public string Description { get; set; }
        public string Office { get; set; }
        public string Project { get; set; }
        public DateTime Creation_Date { get; set; }
        public DateTime Close_Date { get; set; }
        public bool IsOpen { get; set; }
        public int? Id_Selected { get; set; }
        public virtual CandidateDto? Candidate { get; set; }
        public int? Id_Offer_Application { get; set; }
        public virtual Offer_ApplicationDto? Offer_Application { get; set; }


    }
}
