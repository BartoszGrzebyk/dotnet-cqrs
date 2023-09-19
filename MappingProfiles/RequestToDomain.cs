using AutoMapper;
using dotnet_cqrs.Dtos.Items;
using dotnet_cqrs.Models;

namespace dotnet_cqrs.MappingProfiles;

public class RequestToDomain : Profile
{
	public RequestToDomain()
	{
		CreateMap<CreateItemDto, Item>();
		CreateMap<UpdateItemDto, Item>();
	}
}