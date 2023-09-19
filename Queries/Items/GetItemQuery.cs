using dotnet_cqrs.Dtos.Items;
using MediatR;

namespace dotnet_cqrs.Queries.Items;

public class GetItemQuery : IRequest<ItemDto>
{
	public int ItemId {get;}

    public GetItemQuery(int itemId)
    {
        ItemId = itemId;
    }
}