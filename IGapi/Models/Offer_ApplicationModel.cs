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
        public string Description { get; set; }
        public bool IsAccepted { get; set; }
        public int Id_Candidate { get; set; }
        public int Id_Oferta { get; set; }
    }
}
