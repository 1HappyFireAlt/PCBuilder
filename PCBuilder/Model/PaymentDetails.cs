using System.ComponentModel.DataAnnotations;

namespace PCBuilder.Model
{
    public class PaymentDetails
    {
        [Required]
        public string NameOnCard { get; set; }

        [Required]
        public string CardNumber { get; set; }

        [Required]
        public string ExpiryDate { get; set; }

        [Required]
        public string SecurityCode { get; set; }
    }
}
