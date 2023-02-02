using IGapi.Models;
using System.ComponentModel.DataAnnotations;

namespace IGapi.Dtos
{
    public class AdminDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public string Dni { get; set; }
        [DataType(DataType.Date)]
        public DateTime Birthdate { get; set; }
        public string Mail { get; set; }
        public string Password { get; set; }

        public AdminModel ParseToModel()
        {
            return new AdminModel { Id = Id, Name = Name, Gender = Gender, Dni = Dni, Birthdate = Birthdate, Mail = Mail, Password = Password };
        }
    }
}
