namespace Application.Features.Cars.Commands.Create;

public class CreatedCarResponse
{
    public Guid Id { get; set; }
    public Guid ModelId { get; set; }
    public int Kilometer { get; set; }
    public short ModelYear { get; set; }
    public string Plate { get; set; }
    public string Color { get; set; }
    public string Name { get; set; }
}