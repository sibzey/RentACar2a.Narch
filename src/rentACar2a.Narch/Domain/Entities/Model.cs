using NArchitecture.Core.Persistence.Repositories;

namespace Domain.Entities;

public class Model : Entity<Guid>
{
    public Guid BrandId { get; set; }
    public Guid FuelId { get; set; }
    public Guid TransmissionId { get; set; }
    public string Name { get; set; }
    public decimal DailyPrice { get; set; }
    
    public  Brand? Brand { get; set; }
    public Fuel? Fuel { get; set; } = null;
    public Transmission? Transmission { get; set; } = null;

    public Model()
    {
        
    }

    public Model(Guid id, Guid brandId, Guid fuelId, Guid transmissionId, string name, decimal dailyPrice) : this()
    {
        Id = id;
        BrandId = brandId;
        FuelId = fuelId;
        TransmissionId = transmissionId;
        Name = name;
        DailyPrice = dailyPrice;
    }
}
