using apbd_test2_template.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace apbd_test2_template.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
    
    public DbSet<Doctor> Doctors { get; set; }
    public DbSet<Patient> Patients { get; set; }
    public DbSet<Medicament> Medicaments { get; set; }
    public DbSet<Prescription> Prescriptions { get; set; }
    public DbSet<PrescriptionMedicament> PrescriptionMedicaments { get; set; }

    // Define DbSets for your entities here
    // public DbSet<YourEntity> YourEntities { get; set; }
}