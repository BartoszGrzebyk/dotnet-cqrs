using dotnet_cqrs.Models;
using Microsoft.EntityFrameworkCore;

namespace dotnet_cqrs.Data;

public class AppDbContext : DbContext
{
	public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) {}
	public DbSet<Item> Items {get; set;}
}