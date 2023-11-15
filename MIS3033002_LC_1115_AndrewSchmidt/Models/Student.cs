using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace a
{
    public class Student
    {
        [Key]
        public string Id { get; set; }

        public string Name { get; set; }
        public DateTime DOB { get; set; }

        public string favPlace { get; set; }
        public double lon { get; set; }
        public double lat { get; set; }
    }
}
