using System.ComponentModel;

namespace IGapi.Dtos
{
    public class CreateOffer_ApplicationDto
    {
        public int Id { get; set; }
        public DateTime Entry_Date { get; set; }
        public DateTime Assignment_Date { get; set; }
        public string? Description { get; set; }
        [DefaultValue("false")]
        public bool IsAccepted { get; set; }
        public int? Candidate_id { get; set; }
        public int Offer_id { get; set; }
    }
}
