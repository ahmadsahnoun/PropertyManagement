using System;

namespace PropertyManagementSystem.Models
{
    internal class RentHistory
    {
        public int Id { get; set; }
        public Client Client { get; set; }
        public int ClientId { get; set; }
        public Property Property { get; set; }
        public int PropertyId { get; set; }
        public double Price { get; set; }
        public double PaymentPeriod { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}
