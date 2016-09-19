using Dry_Cleaners.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Dry_Cleaners.ViewModels
{
    public class NewCustomerViewModel
    {
        public Customer Customer { get; set; }
        public IEnumerable<DryCleanerStores> DryCleanerStores { get; set; }
        public IEnumerable<KioskLocations> KioskLocations { get; set; }
        public IEnumerable<MembershipType> MembershipType { get; set; }
        public IEnumerable<CreditCardInfo> CreditCardInfo { get; set; }
    }
}