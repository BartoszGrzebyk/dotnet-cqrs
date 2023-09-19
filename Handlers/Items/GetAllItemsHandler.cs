using AutoMapper;
using dotnet_cqrs.Dtos.Items;
using dotnet_cqrs.Queries.Items;
using dotnet_cqrs.Repositories.Interfaces;
using MediatR;

namespace dotnet_cqrs.Handlers.Items;

public class GetAllItemsHandler : IRequestHandler<GetAllItemsQuery, IEnumerable<ItemDto>>
{
	private readonly IMapper mapper;
    private readonly IItemsRepository itemsRepository;

    public GetAllItemsHandler(IMapper mapper, IItemsRepository itemsRepository)
    {
        this.mapper = mapper;
        this.itemsRepository = itemsRepository;
    }

    public async Task<IEnumerable<ItemDto>> Handle(GetAllItemsQuery request, CancellationToken cancellationToken)
    {
        var items = await itemsRepository.GetItemsAsync();

        return mapper.Map<IEnumerable<ItemDto>>(items);
    }
}