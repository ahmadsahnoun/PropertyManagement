﻿namespace PropertyManagementSystem.Models
{
    internal static class CurrentUser
    {
        public static int Id { get; set; }
        public static string UserName { get; set; }
        public static string FullName { get; set; }
        public static string Password { get; set; }
        public static UserType UserType { get; set; }
        public static bool IsActive { get; set; }
    }
}
