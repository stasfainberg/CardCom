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
        public int ID { get; set; }

        public string MyId { get; set; }

        public string UserName { get; set; }

        public string Email { get; set; }

        public DateTime BirthDay { get; set; }

        public Gender Gender { get; set; }

        public string PhoneNumber { get; set; }
    }





}
