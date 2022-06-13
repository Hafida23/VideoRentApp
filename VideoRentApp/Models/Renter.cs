using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace VideoRentApp.Models
{
	public class Renter
	{
		public int RenterId { get; set; }
		[MaxLength(30)]
		[Required]
		public string FirstName { get; set; }
		[MaxLength(30)]
		[Required]
		public string LastName { get; set; }
        public int IdPaymentType { get; set; }
        public virtual PaymentType PaymentTypes { get; set; }
		public virtual ICollection<RentMovie> RentMovies { get; set; }

	}
}
