using System.Data.Entity;

namespace PropertyManagementSystem.Models
{
    internal class MyDbContext : DbContext
    {
        public DbSet<Property> Properties{ get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<PropertyDocument> PropertyDocuments { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Contract> Contracts { get; set; }
        public DbSet<ContractDocument> ContractDocuments { get; set; }
        public DbSet<Payment> Payments { get; set; }
    }
}
