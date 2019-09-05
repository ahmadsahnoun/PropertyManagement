namespace PropertyManagementSystem.Models
{
    internal class User
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string FullName { get; set; }
        public string Password { get; set; }
        public UserType UserType { get; set; }
        public bool IsActive { get; set; }
    }

    internal enum UserType
    {
        Administrator = 1,
        Marketing = 2
    }
}
