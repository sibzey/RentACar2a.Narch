using NArchitecture.Core.Persistence.Repositories;

namespace Domain.Entities;

public class Transmission : Entity<Guid>
{
    public string Name { get; set; }

    public Transmission()
    {
        
    }

    public Transmission(Guid id, string name) : this()
    {
        Id = id;
        Name = name;
    }
}