using Application.Services.Repositories;
using AutoMapper;
using Domain.Entities;
using MediatR;
using NArchitecture.Core.Application.Requests;
using NArchitecture.Core.Application.Responses;
using NArchitecture.Core.Persistence.Paging;

namespace Application.Features.Models.Queries.GetList;

public class GetListModelQuery : IRequest<GetListResponse<GetListModelItemDto>>
{
    public PageRequest PageRequest { get; set; }

    public class GetListModelQueryHandler : IRequestHandler<GetListModelQuery, GetListResponse<GetListModelItemDto>>
    {
        private readonly IModelRepository _modelRepository;
        private readonly IMapper _mapper;

        public GetListModelQueryHandler(IModelRepository modelRepository, IMapper mapper)
        {
            _modelRepository = modelRepository;
            _mapper = mapper;
        }

        public async Task<GetListResponse<GetListModelItemDto>> Handle(GetListModelQuery request, CancellationToken cancellationToken)
        {
            IPaginate<Model> models = await _modelRepository.GetListAsync(
                index: request.PageRequest.PageIndex,
                size: request.PageRequest.PageSize, 
                cancellationToken: cancellationToken
            );

            GetListResponse<GetListModelItemDto> response = _mapper.Map<GetListResponse<GetListModelItemDto>>(models);
            return response;
        }
    }
}
