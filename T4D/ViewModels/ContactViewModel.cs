using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace T4D.ViewModels
{
    public class ContactViewModel
    {
        [Required]
        public string name { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        [EmailAddress]       
        public string email { get; set; }

        [Required]
        public string phone { get; set; }

        [Required]
        public string message { get; set; }
    }
}
