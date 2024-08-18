using PetDelivery.Domain.Models;

namespace PetDelivery.Domain.Entities;

public class ClientAddress : Address
{
    public int ClientId { get; set; }
    public Client Client { get; set; }
}