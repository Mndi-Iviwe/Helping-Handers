using Helping_Handers.Areas.Identity.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Helping_Handers.Models;

namespace Helping_Handers.Data;

public class Helping_HandDbContext : DbContext
{
    public Helping_HandDbContext(DbContextOptions<Helping_HandDbContext> options)
        : base(options){}

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        // Add your customizations after calling base.OnModelCreating(builder);
    }

    //Database Entities
    // User Types
    public DbSet<Helping_User> helping_Users { get; set; }
    public DbSet<Helping_Volunteer> helping_Volunteers { get; set; }
    public DbSet<Helping_Manager> helping_Manager { get; set; }

    // Database Item Tables and Values
    public DbSet<Clothing> Clothes { get; set; }
    public DbSet<Food> Foods { get; set; }
    public DbSet<MedicalSupplies> Medicines { get; set; }
    public DbSet<IncidentAssignment> Assignments { get; set; }
    public DbSet<IncidentReport> Reports { get; set; }


}
