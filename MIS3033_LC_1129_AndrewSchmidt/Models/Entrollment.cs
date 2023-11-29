using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace a
{
    public class Enrollment
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey(nameof(Student))]
        public string StudentId { get; set; }

        public Student Student { get; set; }

        [ForeignKey(nameof(Course))]

        public string CourseId { get; set; }
        public Course Course { get; set; }


        public double Grade { get; set; }
        public char LetterGrade { get; set; } = 'H';

        public DateTime Created { get; set; }

        public char GetLetterGrade()
        {
            if (this.Grade >= 90)
            {
                this.LetterGrade = 'A';
            }
            else if (this.Grade >= 80)
            {
                this.LetterGrade = 'B';
            }
            else if (this.Grade >= 70)
            {
                this.LetterGrade = 'C';
            }
            else if (this.Grade >= 60)
            {
                this.LetterGrade = 'D';
            }
            else
            {
                this.LetterGrade = 'F';
            }
            return this.LetterGrade;
        }

    }
}
