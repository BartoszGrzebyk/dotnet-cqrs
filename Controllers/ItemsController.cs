using AutoMapper;
using dotnet_cqrs.Commands.Items;
using dotnet_cqrs.Dtos.Items;
using dotnet_cqrs.Queries.Items;
using dotnet_cqrs.Repositories.Interfaces;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace dotnet_cqrs.Controllers;

public class ItemsController : BaseController
{
    public ItemsController(IMapper mapper, IMediator mediator) : base(mapper, mediator)
    {
    }

    [HttpGet("{id:int}")]
    public async Task<ActionResult<ItemDto>> GetItemAsync(int id)
    {
        var query = new GetItemQuery(id);
        var item = await mediator.Send(query);

        return item is null ? NotFound() : Ok(item);
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<ItemDto>>> GetItemsAsync()
    {
        var query = new GetAllItemsQuery();
        var items = await mediator.Send(query);

        return Ok(items);
    }

    [HttpPost]
    public async Task<ActionResult<ItemDto>> CreateItemAsync(CreateItemDto createItemDto)
    {
        var command = new CreateItemCommand(createItemDto);
        var item = await mediator.Send(command);

        return CreatedAtAction(
            nameof(GetItemAsync),
            new {id = item.Id},
            item
        );
    }

    [HttpPut]
    public async Task<ActionResult> UpdateItemAsync(UpdateItemDto updateItemDto)
    {
        var command = new UpdateItemCommand(updateItemDto);
        var result = await mediator.Send(command);

        return result is null ? NotFound() : NoContent();
    }

    [HttpDelete("{id:int}")]
    public async Task<ActionResult> DeleteItemAsync(int Id)
    {
        var command = new DeleteItemCommand(Id);
        var result = await mediator.Send(command);

        return result is null ? NotFound() : NoContent();
    }
}