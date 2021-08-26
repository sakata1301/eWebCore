using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eWebCore.ViewModels.System.User
{
    public class RegisterRequest
    {
        public string FirstName { set; get; }
        public string LastName { set; get; }

        [DataType(DataType.Date)]
        public DateTime Dob { set; get; }

        public string Username { get; set; }
        public string Password { get; set; }

        [Display(Name = "Cofirm Password")]
        [DataType(DataType.Password)]
        public string ConfirmPassword { get; set; }

        public string Email { get; set; }
        public string PhoneNumder { get; set; }
    }
}