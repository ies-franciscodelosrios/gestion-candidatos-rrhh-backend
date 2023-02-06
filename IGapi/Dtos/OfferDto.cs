using IGapi.Models;
using System.ComponentModel.DataAnnotations;

namespace IGapi.Dtos
{
    public class OfferDto
    {
        public int Id { get; set; }
        [Required]
        public string Tittle { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public string Office { get; set; }
        [Required]
        public string Project { get; set; }
        public DateTime Creation_Date { get; set; }
        public DateTime Close_Date { get; set; }
        public bool IsOpen { get; set; }
    }
}
