using Application.Services.Repositories;
using Domain.Entities;
using NArchitecture.Core.Application.Rules;
using NArchitecture.Core.CrossCuttingConcerns.Exception.Types;

namespace Application.Features.Models.Rules;

public class ModelBusinessRules : BaseBusinessRules
{
    private readonly IModelRepository _modelRepository;

    public ModelBusinessRules(IModelRepository modelRepository)
    {
        _modelRepository = modelRepository;
    }
    public async Task ModelShouldNotExistsWithSameName(string name)
    {
        Model? modelWithSameName = await _modelRepository.GetAsync(m => m.Name == name);

        if (modelWithSameName is not null)
            throw new BusinessException("Aynı isme sahip bir model zaten mevcut.");
    }
    
}