namespace PropertyManagementSystem.Models
{
    internal class Client
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public ClientType ClientType { get; set; }
        public byte[] Logo { get; set; }
        public string Address { get; set; }
    }

    internal enum ClientType
    {
        Company = 1,
        Individual = 2
    }
}
