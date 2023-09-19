using dotnet_cqrs.Dtos.Items;
using MediatR;

namespace dotnet_cqrs.Queries.Items;

public class GetAllItemsQuery : IRequest<IEnumerable<ItemDto>>
{
	
}