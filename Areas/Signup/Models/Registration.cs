using System.ComponentModel.DataAnnotations;

namespace iTS_ApartBillingCheckList.Areas.Signup.Models
{
    public class Registration
    {

            [Key]
            public int Uid { get; set; }
            [Required]
            public string RegistrantName { get; set; }
            [Required]
            public string Mobile { get; set; }
            [Required]
            public string UserId { get; set; }
            [Required]
            public string Password { get; set; }
            public string? Email { get; set; }

            [Required]
            [DataType(DataType.Date)]
            [DisplayFormat(DataFormatString = "{0: yyyy-MM-dd}", ApplyFormatInEditMode = true)]
            public DateTime RegistrationDate { get; set; }

            [Required]
            public bool IsActive { get; set; }

        
    }
}
