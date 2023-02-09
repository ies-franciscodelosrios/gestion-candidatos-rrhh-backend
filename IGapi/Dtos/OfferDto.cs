using IGapi.Models;
using System.ComponentModel;
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
        [DefaultValue("false")]
        public bool IsOpen { get; set; }
        public List<CreateOffer_ApplicationDto>? Offerings { get; set; }

        public OfferModel ParseToModel() 
        {
            return new OfferModel() 
            {
                Id = Id,
                Tittle = Tittle,
                Description = Description,
                Office = Office,
                Project = Project,
                Close_Date = Close_Date,
                Creation_Date = Creation_Date,
                IsOpen = IsOpen
            };
        }
    }
}
