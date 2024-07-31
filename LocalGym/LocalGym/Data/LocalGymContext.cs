// Data/LocalGymContext.cs
using Microsoft.EntityFrameworkCore;
using LocalGym.Models;

public class LocalGymContext : DbContext
{
    public LocalGymContext(DbContextOptions<LocalGymContext> options) : base(options) { }

    public DbSet<Member> Members { get; set; }
    public DbSet<Trainer> Trainers { get; set; }
    public DbSet<Session> Sessions { get; set; }
}