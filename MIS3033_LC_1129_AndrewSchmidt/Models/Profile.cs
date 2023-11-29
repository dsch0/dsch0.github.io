using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace a
{
    public class Profile
    {
        [Key]

        public string Id { get; set; }

        [ForeignKey(nameof(Student))]
        public string StudentId { get; set; }
        public Student Student { get; set; }

        public string fcolor { get; set; }
        public string address { get; set; }
        public double lon { get; set; }
        public double lat { get; set; }
        public double height { get; set; }
        public double weight { get; set; }

        public DateTime created { get; set; }


    }
}
