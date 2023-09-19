using dotnet_cqrs.Dtos.Items;
using MediatR;

namespace dotnet_cqrs.Commands.Items;

public class CreateItemCommand : IRequest<ItemDto>
{
	public CreateItemDto createItemDto {get;}

    public CreateItemCommand(CreateItemDto createItemDto)
    {
        this.createItemDto = createItemDto;
    }
}