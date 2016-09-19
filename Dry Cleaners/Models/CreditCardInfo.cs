using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Dry_Cleaners.Models
{
    public class CreditCardInfo
    {
        public byte ID { get; set; }
        public string CreditCardType { get; set; }
        [Display(Name = "Credit Card Number")]
        public int CreditCardNumber { get; set; }
        public int CVC { get; set; }
        [Display(Name = "Zip Code Associated with Credit Card")]
        public int Zipcode { get; set; }
    }
}