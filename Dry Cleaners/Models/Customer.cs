using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Dry_Cleaners.Models
{
    public class Customer

    {
        public int ID { get; set; }

        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        [Display(Name = "Zip Code")]
        public int ZipCode { get; set; }
        [Display(Name = "Phone Number")]
        public string PhoneNumber { get; set; }
        [Display(Name = "Email Address")]
        public string EmailAddress { get; set; }
        public DryCleanerStores DryCleanerStores { get; set; }
        [Display(Name = "Dry Cleaners")]
        public byte DryCleanerStoresID { get; set; }
        
        public KioskLocations KioskLocations { get; set; }
        [Display(Name = "Kiosk Location")]
        public byte KioskBuildingID { get; set; }
        
        public MembershipType MembershipType { get; set; }
        [Display(Name = "Membership")]
        public byte MembershipDetailsID { get; set; }

        public CreditCardInfo CreditCardInfo { get; set; }
        [Display(Name = "Please Enter Your Credit Card Information:")]
        public byte CreditCardTypeID { get; set; }
    }
}