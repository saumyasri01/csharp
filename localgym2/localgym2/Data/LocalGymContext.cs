using Microsoft.EntityFrameworkCore;
using LocalGym.Models;

public class LocalGymContext : DbContext
{
    public DbSet<Member> Members { get; set; }
    public DbSet<Trainer> Trainers { get; set; }
    public DbSet<Session> Sessions { get; set; }

    public LocalGymContext(DbContextOptions<LocalGymContext> options) : base(options) { }
}