using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Dry_Cleaners.Models
{
    public class Order
    {
        public int ID { get; set; }
        
        [Display(Name = "Please Enter the Number of Shirts:")]
        public int AmountOfShirts { get; set; }
        
        [Display(Name = "Please Enter the Number of Pants:")]
        public int AmountOfPants { get; set; }
        
        [Display(Name = "Please Enter the Number of Suits:")]
        public int AmountOfSuits { get; set; }
        
        [Display(Name = "Please Enter the Number of Dresses:")]
        public int AmountOfDresses { get; set; }
        [Display(Name = "For Additional Instructions or Comments:")]
        public string CommentSection { get; set; }
    }
}