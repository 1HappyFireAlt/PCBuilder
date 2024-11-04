using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PCBuilder.Model
{
    public class User : IdentityUser
    {
        public string Name { get; set; }
        public string Gender { get; set; }
        public int DateOfBirth { get; set; }
        public List<Order> Orders { get; set; } = [];

        public ICollection<Builds> Builds { get; set; }
        public ICollection<ShopBasket> Baskets { get; set; }
    }
}
