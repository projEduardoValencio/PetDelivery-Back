using Microsoft.EntityFrameworkCore;
using PetDelivery.Domain.Entities;

namespace PetDelivery.Infrastructure.DataAcess;

public class PetDeliveryDbContext : DbContext
{
    public PetDeliveryDbContext(DbContextOptions<PetDeliveryDbContext> options) : base(options){}
    
    public DbSet<Pet> Pets { get; set; }
    public DbSet<User> Users { get; set; }
    public DbSet<Account> Accounts { get; set; }
    public DbSet<Employee> Employees { get; set; }
    public DbSet<Client> Clients { get; set; }
    public DbSet<ClientAddress> ClientAddresses { get; set; }
    public DbSet<ClientReview> ClientReviews { get; set; }
    public DbSet<EmployeeActivies> EmployeeActivities { get; set; }
    public DbSet<Enterprise> Enterprises { get; set; }
    public DbSet<EnterpriseAddress> EnterpriseAddresses { get; set; }
    public DbSet<PetShopActivity> PetShopActivities { get; set; }
    public DbSet<PetShopService> PetShopServices { get; set; }
    public DbSet<ScheduleService> ScheduleServices { get; set; }
    public DbSet<ServiceRequest> ServiceRequests { get; set; }
}