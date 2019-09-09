using System;

namespace PropertyManagementSystem.Models
{
    internal class Payment
    {
        public int Id { get; set; }
        public int ContractId { get; set; }
        public double PayedAmount { get; set; }
        public DateTime PaymentDate { get; set; }
    }
}
