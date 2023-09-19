using AutoMapper;
using dotnet_cqrs.Commands.Items;
using dotnet_cqrs.Dtos.Items;
using dotnet_cqrs.Models;
using dotnet_cqrs.Repositories.Interfaces;
using MediatR;

namespace dotnet_cqrs.Handlers.Items;

public class CreateItemHandler : IRequestHandler<CreateItemCommand, ItemDto>
{
	private readonly IMapper mapper;
    private readonly IItemsRepository itemsRepository;

    public CreateItemHandler(IMapper mapper, IItemsRepository itemsRepository)
    {
        this.mapper = mapper;
        this.itemsRepository = itemsRepository;
    }

    public async Task<ItemDto> Handle(CreateItemCommand request, CancellationToken cancellationToken)
    {
        var item = mapper.Map<Item>(request.createItemDto);

        var result = await itemsRepository.CreateItemAsync(item);

        return mapper.Map<ItemDto>(result);
    }
}