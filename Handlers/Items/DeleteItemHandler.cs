using AutoMapper;
using dotnet_cqrs.Commands.Items;
using dotnet_cqrs.Models;
using dotnet_cqrs.Repositories.Interfaces;
using MediatR;

namespace dotnet_cqrs.Handlers.Items;

public class DeleteItemHandler : IRequestHandler<DeleteItemCommand, Item>
{
	private readonly IMapper mapper;
	private readonly IItemsRepository itemsRepository;

    public DeleteItemHandler(IMapper mapper, IItemsRepository itemsRepository)
    {
				this.mapper = mapper;
        this.itemsRepository = itemsRepository;
    }

    public async Task<Item> Handle(DeleteItemCommand request, CancellationToken cancellationToken)
    {
        return await itemsRepository.DeleteItemAsync(request.Id);
    }
}