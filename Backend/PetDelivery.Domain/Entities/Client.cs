using System.ComponentModel.DataAnnotations.Schema;
using PetDelivery.Domain.Models;

namespace PetDelivery.Domain.Entities;

public class Client : EntityBase
{
    public int UserId { get; set; }
    [ForeignKey("UserId")]
    public User User { get; set; }
    
    public ClientAddress Address { get; set; }
    public List<Pet> Pets { get; set; }
}