using System;

namespace DShop.Services.Customers.Dtos
{
    public class CustomerDto
    {
        public Guid Id { get; set; }
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public DateTime CreatedAt { get; set; }        
    }
}