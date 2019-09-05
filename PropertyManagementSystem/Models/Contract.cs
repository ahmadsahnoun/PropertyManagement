using System;

namespace PropertyManagementSystem.Models
{
    internal class Contract
    {
        public int Id { get; set; }
        public Property Property { get; set; }
        public int PropertyId { get; set; }
        public double Price { get; set; }
        public Client Client { get; set; }
        public int ClientId { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public PaymentTypes Payment { get; set; }
        public PaymentMethod Method { get; set; }
        public float PayEvery { get; set; }
        public PaymentPeriod Period { get; set; }
        public DateTime PayDate { get; set; }
        public string PayStatus { get; set; }
    }

    internal enum PaymentPeriod
    {
        Day = 1,
        Week = 2,
        Month = 3,
        Year = 4
    }

    internal enum PaymentTypes
    {
        Prepaid = 1,
        Postpaid = 2
    }

    internal enum PaymentMethod
    {
        Cash = 1,
        Transform = 2,
        Cheque = 3
    }
}
