using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
namespace eProject3_6.ViewModel
{
    public class Contact
    {
        [Required]
        public string Email { get => Email; set => Email = value; }
        [Required]
        public string Subject { get =>Subject ; set => Subject = value; }
        [Required]
        public string Message { get =>Message; set=> Message = value; }

    }
}
