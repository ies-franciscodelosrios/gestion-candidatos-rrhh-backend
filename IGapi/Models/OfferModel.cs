using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IGapi.Models
{

    [Table("Offer")]
    public class OfferModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Tittle { get; set; }
        public string Description { get; set; }
        public string Office { get; set; }
        public string Project { get; set; }
        public DateTime Creation_Date { get; set; }
        public DateTime Close_Date { get; set; }
        public bool IsOpen { get; set; }
        public int Id_Selected { get; set; }
        public int Id_Offer { get; set; }
    }
}
