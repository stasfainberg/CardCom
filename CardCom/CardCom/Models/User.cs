using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CardCom.Models
{

    public enum Gender
    {
        Male,
        Female,
        Other
    }

    public class User
    {

        [Key]
        public int ID { get; set; }

        [Required]
        [Display(Name = "ID")]
        [RegularExpression("^[0-9]*$", ErrorMessage = "ID must be numeric")]
        [StringLength(9, ErrorMessage = "ID should contain 9 digits", MinimumLength = 9)]
        public string MyId { get; set; }

        [Required]
        [Display(Name = "Full Name")]
        [StringLength(30, ErrorMessage = "Too long")]
        [RegularExpression(@"^(([A-za-z]+[\s]{1}[A-za-z]+)|([A-Za-z]+))$", ErrorMessage = "Full Name must be characters")]
        public string UserName { get; set; }

        [EmailAddress]
        [Display(Name = "Email Address")]
        [RegularExpression(@"^\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$",
                    ErrorMessage = "Please enter a valid email address")]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "Birthday")]
        public DateTime BirthDay { get; set; }

        [Display(Name = "Gender")]
        public Gender? Gender { get; set; }

        [Phone]
        [Display(Name = "Phone")]
        [RegularExpression("^[0-9]*$", ErrorMessage = "Phone must be numeric")]
        public string PhoneNumber { get; set; }
    }





}
