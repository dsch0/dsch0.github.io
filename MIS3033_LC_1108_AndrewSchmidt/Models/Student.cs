using System.ComponentModel.DataAnnotations;

namespace MIS3033_LC_1108_AndrewSchmidt.Models
{
    public class Student
    {
        [Key]

        public string id { get; set; }

        public string name { get; set; }

        public DateTime DOB { get; set; }
    }
}
