using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Dry_Cleaners.Models
{
    public class CreditCardInfo
    {
        public byte ID { get; set; }
        public string CreditCardType { get; set; }
        public int CreditCardNumber { get; set; }
        public int CVC { get; set; }
        public int Zipcode { get; set; }
    }
}