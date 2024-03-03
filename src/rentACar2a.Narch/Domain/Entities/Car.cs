using NArchitecture.Core.Persistence.Repositories;

namespace Domain.Entities;

public class Car : Entity<Guid>
{
    public string Name { get; set; }
    public Guid ColorId { get; set; }
    public Guid ModelId { get; set; }
    public int CarState { get; set; }
    public int Kilometer { get; set; }
    public int ModelYear { get; set; } 
    public Model? Model { get; set; } = null;
}
