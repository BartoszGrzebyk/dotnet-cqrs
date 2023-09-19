using dotnet_cqrs.Dtos.Items;
using dotnet_cqrs.Models;
using MediatR;

namespace dotnet_cqrs.Commands.Items;

public class UpdateItemCommand : IRequest<Item>
{
	public UpdateItemDto  UpdateItemDto {get;}

    public UpdateItemCommand(UpdateItemDto UpdateItemDto)
    {
        this.UpdateItemDto = UpdateItemDto;
    }
}