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
        public string DayOfWeek { get; set; }
        public string PickUpTime { get; set; }
        [Display(Name = "Email Address Associated with Account")]
        public string EmailAddress { get; set; }
    }
}