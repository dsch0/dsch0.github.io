using Microsoft.EntityFrameworkCore;
using MIS3033_LC_1108_AndrewSchmidt.Models;

namespace MIS3033_LC_1108_AndrewSchmidt.Data
{
    public class StuDB : DbContext// Change DbCon to your own database connect class name
    {
        public DbSet<Student> Students { get; set; }// Define a table in the database. The table name here is: Students
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=129.15.67.240;Database=schm00961108;Port=5432;Username=schm0096;Password=ZZ8xJuXwTgrZJicS23YV");
            // start your database name with your netid
        }
    }
}
