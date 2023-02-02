using IGapi.Dtos;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IGapi.Models
{
    public class AdminModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public string Dni { get; set; }
        [DataType(DataType.Date)]
        public DateTime Birthdate  { get; set; }
        public string Mail { get; set; }
        public string Password { get; set; }

        public AdminDto ParseToDto()
        {
            return new AdminDto { Id = Id, Name = Name, Gender = Gender, Dni = Dni, Birthdate = Birthdate, Mail = Mail, Password = Password };
        }
    }
}
