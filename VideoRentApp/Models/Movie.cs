using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace VideoRentApp.Models
{
	public class Movie
	{
		public int MovieId { get; set; }
		public string Title { get; set; }
		public string Description { get; set; }
		public string ImageUrl { get; set; }
		public int Length { get; set; }
		[BindProperty, DataType(DataType.Date)]
		[Display(Name = "Date Release")]
		public DateTime DateRelease { get; set; }
		public string Genre { get; set; }
		[MaxLength(50)]
		[Display(Name = "Main Actress")]
		public string MainActress { get; set; }
		public string ImdbUrl { get; set; }

        public virtual ICollection<RentMovie> RentMovies { get; set; }
    }
}
