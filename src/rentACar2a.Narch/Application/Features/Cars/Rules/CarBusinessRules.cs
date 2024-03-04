using Application.Services.Repositories;
using Domain.Entities;
using NArchitecture.Core.Application.Rules;
using NArchitecture.Core.CrossCuttingConcerns.Exception.Types;

namespace Application.Features.Cars.Rules;

public class CarBusinessRules : BaseBusinessRules
{
    private readonly ICarRepository _carRepository;

    public CarBusinessRules(ICarRepository carRepository)
    {
        carRepository = _carRepository;
    }
   
    public async Task CarShouldNotExistsWithSameName(string name)
    {
        Car? carWithSameName = await _carRepository.GetAsync(c => c.Name == name);

        if (carWithSameName is not null)
            throw new BusinessException("Aynı isme sahip bir araba zaten mevcut.");
    }
}