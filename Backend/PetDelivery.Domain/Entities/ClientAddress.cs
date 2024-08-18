using System.ComponentModel.DataAnnotations.Schema;
using PetDelivery.Domain.Models;

namespace PetDelivery.Domain.Entities;

public class ClientAddress : Address
{
    public int ClientId { get; set; }
    [ForeignKey("ClientId")]
    public Client Client { get; set; }
}