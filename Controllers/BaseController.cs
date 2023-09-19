using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace dotnet_cqrs.Controllers;

[Route("[controller]")]
[ApiController]
public class BaseController : ControllerBase
{
		protected readonly IMapper mapper;
    protected readonly IMediator mediator;

    public BaseController(IMapper mapper, IMediator mediator)
    {
			this.mapper = mapper;
			this.mediator = mediator;
    }
}