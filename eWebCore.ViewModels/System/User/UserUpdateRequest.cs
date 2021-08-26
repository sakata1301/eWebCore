using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eWebCore.ViewModels.System.User
{
    public class UserUpdateRequest
    {
        public Guid Id { get; set; }
        public string FirstName { set; get; }
        public string LastName { set; get; }

        [DataType(DataType.Date)]
        public DateTime Dob { set; get; }

        public string Email { get; set; }
        public string PhoneNumder { get; set; }
    }
}