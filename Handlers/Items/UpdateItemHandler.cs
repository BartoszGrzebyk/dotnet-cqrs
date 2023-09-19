using AutoMapper;
using dotnet_cqrs.Commands.Items;
using dotnet_cqrs.Dtos.Items;
using dotnet_cqrs.Models;
using dotnet_cqrs.Repositories.Interfaces;
using MediatR;

namespace dotnet_cqrs.Handlers.Items;

public class UpdateItemHandler : IRequestHandler<UpdateItemCommand, Item>
{
		private readonly IMapper mapper;
    private readonly IItemsRepository itemsRepository;

    public UpdateItemHandler(IMapper mapper, IItemsRepository itemsRepository)
    {
        this.mapper = mapper;
        this.itemsRepository = itemsRepository;
    }

    public async Task<Item> Handle(UpdateItemCommand request, CancellationToken cancellationToken)
    {
        var item = mapper.Map<Item>(request.UpdateItemDto);

        return await itemsRepository.UpdateItemAsync(item);
    }
}