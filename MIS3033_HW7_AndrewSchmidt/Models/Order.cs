namespace MIS3033_HW7_AndrewSchmidt.Models
{
    public class Order
    {
        public string Id { get; set; }
        public int nCogs { get; set; }
        public int nGears { get; set; }
        public double subtotal { get; set; }

        public int level { get; set; }

        public double CalSubtotal()
        {
            this.subtotal = 100 * this.nCogs + 200 * this.nGears;
            return this.subtotal;
        }
        public int CalSubtotalLevel()
        {
            if (this.subtotal > 10000)
            {
                this.level = 1;
            }
            else if (this.subtotal >=5000)
            {
                this.level = 2;
            }
            else
            {
                this.level = 3;
            }
            return this.level;
              
        }
    }
}
