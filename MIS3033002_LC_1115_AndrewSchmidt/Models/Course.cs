using System.ComponentModel.DataAnnotations;

namespace a
{
    public class Course
    {
        [Key]
        public string Id { get; set; }
        public string Name { get; set; }
        public int CreditHours { get; set; }

        public DateTime Created { get; set; }

    }
}
