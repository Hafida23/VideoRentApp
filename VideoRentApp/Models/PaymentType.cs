using System.Collections.Generic;

namespace VideoRentApp.Models
{
    public class PaymentType
    {
        public int PaymentTypeId { get; set; }
        public string TypeOfPayment { get; set; }
        public virtual ICollection<Renter> Renters { get; set; }
    }
}
