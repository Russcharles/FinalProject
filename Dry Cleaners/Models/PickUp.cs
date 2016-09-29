using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Dry_Cleaners.Models
{
    public class PickUp
    {
        public byte ID { get; set; }
        public string Date { get; set; }
        public string Time { get; set; }
        [Display(Name = "Phone number Associated with Account")]
        public string PhoneNumber { get; set; }
    }
}