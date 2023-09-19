using dotnet_cqrs.Models;
using MediatR;

namespace dotnet_cqrs.Commands.Items;

public class DeleteItemCommand : IRequest<Item>
{
	public int Id {get;}

    public DeleteItemCommand(int id)
    {
        Id = id;
    }
}