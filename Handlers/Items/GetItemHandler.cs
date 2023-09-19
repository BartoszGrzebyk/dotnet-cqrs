using AutoMapper;
using dotnet_cqrs.Dtos.Items;
using dotnet_cqrs.Queries.Items;
using dotnet_cqrs.Repositories.Interfaces;
using MediatR;

namespace dotnet_cqrs.Handlers.Items;

public class GetItemHandler : IRequestHandler<GetItemQuery, ItemDto>
{
		private readonly IMapper mapper;
    private readonly IItemsRepository itemsRepository;

    public GetItemHandler(IMapper mapper, IItemsRepository itemsRepository)
    {
        this.mapper = mapper;
        this.itemsRepository = itemsRepository;
    }

    public async Task<ItemDto> Handle(GetItemQuery request, CancellationToken cancellationToken)
    {
        var item = await itemsRepository.GetItemAsync(request.ItemId);

				return item is null ? null : mapper.Map<ItemDto>(item);
    }
}