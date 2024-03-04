using NArchitecture.Core.Persistence.Repositories;

namespace Domain.Entities;

public class Fuel : Entity<Guid>
{
    public string Name { get; set; }

    public Fuel()
    {
        
    }

    public Fuel(string name, Guid id) : this()
    {
        Name = name;
        Id = id;
    }
}
