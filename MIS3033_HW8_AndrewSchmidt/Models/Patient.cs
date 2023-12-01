namespace MIS3033_HW8_AndrewSchmidt.Models
{
    public class Patient
    {
        public string ID {  get; set; }
        public string Name { get; set; }
        public int age { get; set; }
        public double weight { get; set; }
        public double BMI { get; set; }
        public string BMILevel { get; set; }

        public Patient() { }

        public Patient(string id, string name, int age, double weight, double BMI)
        {
            this.ID = id;
            this.Name = name;
            this.age=age;
            this.weight = weight;
            this.BMI = BMI;
        }
        public string GetBMILevel()
        { 
            if (this.BMI<18.5)
            {
                this.BMILevel = "Under Weight";
            }
            else if (this.BMI < 25)
            {
                this.BMILevel = "Healthy";
            }
            else if (this.BMI<30)
            {
                this.BMILevel = "Overweight";
            }
            else
            {
                this.BMILevel = "Obesity";
                    
            }
            return this.BMILevel;
        }

    }
}
