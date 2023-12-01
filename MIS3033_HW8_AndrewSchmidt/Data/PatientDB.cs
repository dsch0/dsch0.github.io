using Microsoft.EntityFrameworkCore;
using MIS3033_HW8_AndrewSchmidt.Models;

namespace MIS3033_HW8_AndrewSchmidt.Data
{
    public class PatientDB : DbContext// Change DbCon to your own database connect class name
    {
        public DbSet<Patient> Patients { get; set; }// Define a table in the database. The table name here is: Students
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=129.15.67.240;Database=schm0096hw8;Port=5432;Username=schm0096;Password=ZZ8xJuXwTgrZJicS23YV");
        }
    }

}
