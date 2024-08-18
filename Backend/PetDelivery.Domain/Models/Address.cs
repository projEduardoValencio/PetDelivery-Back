namespace PetDelivery.Domain.Models;

public class Address : EntityBase
{
    public string Street { get; set; } = string.Empty;
    public int Number { get; set; }
    public string Neighborhood { get; set; } = string.Empty;
    public string City { get; set; } = string.Empty;
    public string State { get; set; } = string.Empty;
    public string County { get; set; } = string.Empty;
}