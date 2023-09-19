using dotnet_cqrs.Models;

namespace dotnet_cqrs.Repositories.Interfaces;

public interface IItemsRepository
{
	Task<IEnumerable<Item>> GetItemsAsync();
	Task<Item> GetItemAsync(int id);
	Task<Item> CreateItemAsync(Item item);
	Task<Item> UpdateItemAsync(Item item);
	Task<Item> DeleteItemAsync(int id);
}