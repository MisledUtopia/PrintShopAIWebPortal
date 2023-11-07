using AuthSystem.Areas.Identity.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Emit;

namespace AuthSystem.Data;

public class AuthDbContext : IdentityDbContext<ApplicationUser>
{
    public AuthDbContext(DbContextOptions<AuthDbContext> options)
        : base(options)
    {
    }

    public DbSet<ApplicationUser> Users { get; set; }
    public DbSet<AuthSystem.Models.Key> Keys { get; set; }
    public DbSet<AuthSystem.Models.Pod> Pods { get; set; }
    public DbSet<AuthSystem.Models.Product> Products { get; set; }
    public DbSet<AuthSystem.Models.Store> Stores { get; set; }
    public DbSet<AuthSystem.Models.Style> Styles { get; set; }
    public DbSet<AuthSystem.Models.Topic> Topics { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

    }
}
