using dotnet_cqrs.Data;
using dotnet_cqrs.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace dotnet_cqrs.Repositories;

public class GenericRepository<T> where T : class
{
	protected AppDbContext context;
	internal DbSet<T> dbSet;
	
	public GenericRepository (
		AppDbContext context
	){
		this.context = context;
		dbSet = context.Set<T>();
	}
}