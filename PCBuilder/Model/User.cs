using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PCBuilder.Model
{
    public class User : IdentityUser
    {
        public string Name { get; set; }
        public string Gender { get; set; }
        public DateTime DateOfBirth { get; set; }
        public List<Order> Orders { get; set; } = [];

        public ICollection<Builds> Builds { get; set; }
        public ICollection<ShopBasket> Baskets { get; set; }

        private DateTime _dateOfBirth;
        public bool TrySetDateOfBirth(DateTime dateOfBirth)
        {
            var age = DateTime.Today.Year - dateOfBirth.Year;
            if (dateOfBirth > DateTime.Today.AddYears(-age)) age--;

            if (age >= 13)
            {
                DateOfBirth = dateOfBirth;
                return true;
            }

            return false;
        }
    }
}
