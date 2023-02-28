using System;

namespace CoreWeb.Data.Models
{
    public class Customer
    {
        public Guid Id { get; set; }
        public string Account { get; set; }
        public string Password { get; set; }
        public string? FirstName { get; set; }
        public string? MiddleName { get; set; }
        public string? LastName { get; set; }
        public string? Address { get; set; }
        public string? Email { get; set; }
        public string? Phone { get; set; }
        public DateTime DateCreated { get; set; } = DateTime.Now;
        public DateTime DateUpdated { get; set; } = DateTime.Now;
    }

    public class Address
    {
        public string City { get; set; }
        public string Street { get; set; }
        public string UnitNumber { get; set; }
        public string PostalCode { get; set; }
    }
}