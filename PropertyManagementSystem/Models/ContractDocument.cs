namespace PropertyManagementSystem.Models
{
    class ContractDocument
    {
        public int Id { get; set; }
        public Contract Contract { get; set; }
        public int ContractId { get; set; }
        public byte[] Image { get; set; }
    }
}
