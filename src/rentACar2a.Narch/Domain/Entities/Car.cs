using NArchitecture.Core.Persistence.Repositories;

namespace Domain.Entities;

public class Car : Entity<Guid>
{
    public string Name { get; set; }
    public string Color { get; set; }
    public Guid ModelId { get; set; }
    //public int CarState { get; set; }
    public int Kilometer { get; set; }
    public string Plate { get; set; }
    public short ModelYear { get; set; } 
    public Model? Model { get; set; } = null;

    public Car()
    {
        
    }

    public Car(Guid id, Guid modelId, string name, string color, int kilometer, short modelYear, string plate) : this()
    {
        Id = id;
        ModelId = modelId;
        Name = name;
        Color = color;
        Kilometer = kilometer;
        ModelYear = modelYear;
        Plate = plate;
    }
}
