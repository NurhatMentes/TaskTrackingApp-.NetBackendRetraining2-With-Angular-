﻿namespace Core.Entities.DTOs
{
    public class UserForRegisterDto : IDTOs
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
