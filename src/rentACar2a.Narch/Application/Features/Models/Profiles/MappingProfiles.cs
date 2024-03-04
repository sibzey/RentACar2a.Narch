using Application.Features.Models.Commands;
using Application.Features.Models.Queries.GetList;
using AutoMapper;
using Domain.Entities;
using NArchitecture.Core.Application.Responses;
using NArchitecture.Core.Persistence.Paging;

namespace Application.Features.Models.Profiles;

public class MappingProfiles : Profile
{
    public MappingProfiles()
    {
        CreateMap<Model, CreateModelCommand>().ReverseMap();
        CreateMap<Model, CreatedModelResponse>().ReverseMap();
        CreateMap<Model, GetListModelItemDto>().ReverseMap();
        CreateMap<IPaginate<Model>, GetListResponse<GetListModelItemDto>>().ReverseMap();
    }
}