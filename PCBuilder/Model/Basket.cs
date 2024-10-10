using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace PCBuilder.Model
{
    public class Basket
    {
        public int Id { get; set; }

        [Required]
        public string Payment { get; set; }

        public User User { get; set; }
        public Component Component { get; set; }
    }
}
