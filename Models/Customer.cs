using System.ComponentModel.DataAnnotations;

namespace project_asp.Models
{
    public class Customer
    {
        [Key]
        public int Cus_Id { get; set; }

        [Required]
        public string Cus_Username { get; set; }

        [Required]
        public string Cus_Password { get; set; }

        [Required]
        public string Cus_Fullname { get; set; }

        [Required]
        public string Cus_Tel {  get; set; }

        [Required]
        public string Cus_Email { get; set; }


    }
}
