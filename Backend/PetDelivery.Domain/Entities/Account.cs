using PetDelivery.Domain.Enums;
using PetDelivery.Domain.Models;

namespace PetDelivery.Domain.Entities;

public class Account : EntityBase
{
    public string Uuid { get; set; }
    public string Username { get; set; }
    public string Password { get; set; }
    public bool Activated { get; set; }
    public DateTime LastLogin { get; set; }
    public AccountType AccountType  { get; set; }
    
    public int UserId { get; set; }
    public User User { get; set; }
}