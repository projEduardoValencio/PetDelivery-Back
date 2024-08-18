using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using PetDelivery.Domain.Enums;
using PetDelivery.Domain.Models;

namespace PetDelivery.Domain.Entities;

public class ServiceRequest : EntityBase
{
    [Required]
    public string Uuid { get; set; }
    public string ClientDescription { get; set; }
    [Required]
    public decimal TotalPrice { get; set; }
    
    public int ServiceId { get; set; }
    [ForeignKey("ServiceId")]
    public PetShopService Service { get; set; }
    
    public int EmployeeId { get; set; }
    [ForeignKey("EmployeeId")]
    public Employee Employee { get; set; }
    
    public int ClientId { get; set; }
    [ForeignKey("ClientId")]
    public Client Client { get; set; }
    
    public int PetId { get; set; }
    [ForeignKey("PetId")]
    public Pet Pet { get; set; }
    
    public int EnterpriseId { get; set; }
    [ForeignKey("EnterpriseId")]
    public Enterprise Enterprise { get; set; }
    
    public ScheduleService ScheduleService { get; set; }
}