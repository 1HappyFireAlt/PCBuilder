using Microsoft.AspNetCore.Identity;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PCBuilder.Model
{
    public class User : IdentityUser
    {
        public string Name { get; set; }
        public string Gender { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string PostCode { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public List<Order> Orders { get; set; } = [];

        public ICollection<Builds> Builds { get; set; }
        public ICollection<ShopBasket> Baskets { get; set; }

    }
}
