using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eWebCore.ViewModels.System.User
{
    public class RegisterRequest
    {
        public string FirstName { set; get; }
        public string LastName { set; get; }
        public DateTime Dob { set; get; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
        public string Email { get; set; }
        public string PhoneNumder { get; set; }
    }
}