using System.ComponentModel.DataAnnotations;

namespace Customer_Management_Uni.Models
{
    public class Provider
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ServiceType { get; set; }
        public int Number { get; set; }
        [EmailAddress]
        public string EmailAddress { get; set; }
    }
}
