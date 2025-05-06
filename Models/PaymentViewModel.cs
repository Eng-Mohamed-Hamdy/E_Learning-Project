using System.ComponentModel.DataAnnotations;

namespace E_learningPlatform.Models
{
    public class PaymentViewModel
    {
        public int CourseId { get; set; }
        public string CourseTitle { get; set; }
        public decimal Price { get; set; }
        
        public string PaymentMethod { get; set; }
        public string CardNumber { get; set; }
        public string ExpirationDate { get; set; }
        public string CVV { get; set; }
    }
}