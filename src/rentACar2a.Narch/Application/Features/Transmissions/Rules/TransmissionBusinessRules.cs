using Application.Services.Repositories;
using Domain.Entities;
using NArchitecture.Core.Application.Rules;
using NArchitecture.Core.CrossCuttingConcerns.Exception.Types;

namespace Application.Features.Transmissions.Rules;

public class TransmissionBusinessRules : BaseBusinessRules
{
    private readonly ITransmissionRepository _transmissionRepository;

    public TransmissionBusinessRules(ITransmissionRepository transmissionRepository)
    {
        _transmissionRepository = transmissionRepository;
    }
    public async Task TransmissionShouldNotExistsWithSameName(string name)
    {
        Transmission? transmissionWithSameName = await _transmissionRepository.GetAsync(f => f.Name == name);

        if (transmissionWithSameName is not null)
            throw new BusinessException("Aynı isme sahip bir transmission zaten mevcut.");
    }
}
