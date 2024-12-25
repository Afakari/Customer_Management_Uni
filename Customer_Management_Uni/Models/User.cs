using System.ComponentModel.DataAnnotations;

namespace Customer_Management_Uni.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        [EmailAddress]
        public string EmailAddress { get; set; }
        public int Number { get; set; }
    }
}
