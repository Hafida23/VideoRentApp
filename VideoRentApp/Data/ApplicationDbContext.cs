using Microsoft.EntityFrameworkCore;
using System;
using VideoRentApp.Models;

namespace VideoRentApp.Data
{
	public class ApplicationDbContext : DbContext
	{
		public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
		{

		}
		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Movie>()
				.HasData(
					new Movie { MovieId = 1, Length = 125, Title = "Titanic", Genre = "Romance", MainActress = "Kate Winslet", DateRelease = new DateTime(1997, 12, 19), Description = "A seventeen-year-old aristocrat falls in love with a kind but poor artist aboard the luxurious, ill-fated R.M.S. Titanic", ImageUrl = "Titanic.jpg", ImdbUrl = "https://www.imdb.com/title/tt0120338/" },
					new Movie { MovieId = 2, Length = 105, Title = "Inglorious Basterds", Genre = "Action", MainActress = "Diane Kruger", DateRelease = new DateTime(2009, 08, 21), Description = "In Nazi-occupied France during World War II, a plan to assasinate Nazi leaders by a group of Jewish U.S. soldiers coincides with a theatre owner's vengeful plans for the same", ImageUrl = "InBasterds.jpg", ImdbUrl = "https://www.imdb.com/title/tt0361748/"},
					new Movie { MovieId = 3, Length = 135, Title = "Star Trek - Into Darkness", Genre = "Sci-Fi", MainActress = "Zoe Saldana", DateRelease = new DateTime(2013, 05, 16), Description = "After the crew of the Enterprise find an unstoppable force of terror from within their own organization, Captain Kirk leads a manhunt to a war-zone world to capture a one-man weapon of mass destruction", ImageUrl = "StarTrek.jpg", ImdbUrl = "https://www.imdb.com/title/tt1408101/"},
					new Movie { MovieId = 4, Length = 110, Title = "Top Gun", Genre = "Action-Drama", MainActress = "Kelly McGills", DateRelease = new DateTime(1986, 05, 16), Description = "As students at the United States Navy's elite fighter weapons school compete to be best in the class, one daring young pilot learns a few things from a civilian instructor that are not taught in the classroom.", ImageUrl = "topgun.jpg", ImdbUrl = "https://www.imdb.com/title/tt0092099/"},
					new Movie { MovieId = 5, Length = 125, Title = "Titanic", Genre = "Romance", MainActress = "Kate Winslet", DateRelease = new DateTime(1997, 12, 19), Description = "A seventeen-year-old aristocrat falls in love with a kind but poor artist aboard the luxurious, ill-fated R.M.S. Titanic", ImageUrl = "Titanic.jpg", ImdbUrl = "https://www.imdb.com/title/tt0120338/" },
					new Movie { MovieId = 6, Length = 105, Title = "Inglorious Basterds", Genre = "Action", MainActress = "Diane Kruger", DateRelease = new DateTime(2009, 08, 21), Description = "In Nazi-occupied France during World War II, a plan to assasinate Nazi leaders by a group of Jewish U.S. soldiers coincides with a theatre owner's vengeful plans for the same", ImageUrl = "InBasterds.jpg", ImdbUrl = "https://www.imdb.com/title/tt0361748/" },
					new Movie { MovieId = 7, Length = 135, Title = "Star Trek - Into Darkness", Genre = "Sci-Fi", MainActress = "Zoe Saldana", DateRelease = new DateTime(2013, 05, 16), Description = "After the crew of the Enterprise find an unstoppable force of terror from within their own organization, Captain Kirk leads a manhunt to a war-zone world to capture a one-man weapon of mass destruction", ImageUrl = "StarTrek.jpg", ImdbUrl = "https://www.imdb.com/title/tt1408101/" },
					new Movie { MovieId = 8, Length = 110, Title = "Top Gun", Genre = "Action-Drama", MainActress = "Kelly McGills", DateRelease = new DateTime(1986, 05, 16), Description = "As students at the United States Navy's elite fighter weapons school compete to be best in the class, one daring young pilot learns a few things from a civilian instructor that are not taught in the classroom.", ImageUrl = "topgun.jpg", ImdbUrl = "https://www.imdb.com/title/tt0092099/" },
					new Movie { MovieId = 9, Length = 125, Title = "Titanic", Genre = "Romance", MainActress = "Kate Winslet", DateRelease = new DateTime(1997, 12, 19), Description = "A seventeen-year-old aristocrat falls in love with a kind but poor artist aboard the luxurious, ill-fated R.M.S. Titanic", ImageUrl = "Titanic.jpg", ImdbUrl = "https://www.imdb.com/title/tt0120338/" },
					new Movie { MovieId = 10, Length = 105, Title = "Inglorious Basterds", Genre = "Action", MainActress = "Diane Kruger", DateRelease = new DateTime(2009, 08, 21), Description = "In Nazi-occupied France during World War II, a plan to assasinate Nazi leaders by a group of Jewish U.S. soldiers coincides with a theatre owner's vengeful plans for the same", ImageUrl = "InBasterds.jpg", ImdbUrl = "https://www.imdb.com/title/tt0361748/" },
					new Movie { MovieId = 11, Length = 135, Title = "Star Trek - Into Darkness", Genre = "Sci-Fi", MainActress = "Zoe Saldana", DateRelease = new DateTime(2013, 05, 16), Description = "After the crew of the Enterprise find an unstoppable force of terror from within their own organization, Captain Kirk leads a manhunt to a war-zone world to capture a one-man weapon of mass destruction", ImageUrl = "StarTrek.jpg", ImdbUrl = "https://www.imdb.com/title/tt1408101/" },
					new Movie { MovieId = 12, Length = 110, Title = "Top Gun", Genre = "Action-Drama", MainActress = "Kelly McGills", DateRelease = new DateTime(1986, 05, 16), Description = "As students at the United States Navy's elite fighter weapons school compete to be best in the class, one daring young pilot learns a few things from a civilian instructor that are not taught in the classroom.", ImageUrl = "topgun.jpg", ImdbUrl = "https://www.imdb.com/title/tt0092099/" },
					new Movie { MovieId = 13, Length = 125, Title = "Titanic", Genre = "Romance", MainActress = "Kate Winslet", DateRelease = new DateTime(1997, 12, 19), Description = "A seventeen-year-old aristocrat falls in love with a kind but poor artist aboard the luxurious, ill-fated R.M.S. Titanic", ImageUrl = "Titanic.jpg", ImdbUrl = "https://www.imdb.com/title/tt0120338/" },
					new Movie { MovieId = 14, Length = 105, Title = "Inglorious Basterds", Genre = "Action", MainActress = "Diane Kruger", DateRelease = new DateTime(2009, 08, 21), Description = "In Nazi-occupied France during World War II, a plan to assasinate Nazi leaders by a group of Jewish U.S. soldiers coincides with a theatre owner's vengeful plans for the same", ImageUrl = "InBasterds.jpg", ImdbUrl = "https://www.imdb.com/title/tt0361748/" },
					new Movie { MovieId = 15, Length = 135, Title = "Star Trek - Into Darkness", Genre = "Sci-Fi", MainActress = "Zoe Saldana", DateRelease = new DateTime(2013, 05, 16), Description = "After the crew of the Enterprise find an unstoppable force of terror from within their own organization, Captain Kirk leads a manhunt to a war-zone world to capture a one-man weapon of mass destruction", ImageUrl = "StarTrek.jpg", ImdbUrl = "https://www.imdb.com/title/tt1408101/" },
					new Movie { MovieId = 16, Length = 110, Title = "Top Gun", Genre = "Action-Drama", MainActress = "Kelly McGills", DateRelease = new DateTime(1986, 05, 16), Description = "As students at the United States Navy's elite fighter weapons school compete to be best in the class, one daring young pilot learns a few things from a civilian instructor that are not taught in the classroom.", ImageUrl = "topgun.jpg", ImdbUrl = "https://www.imdb.com/title/tt0092099/" },
					new Movie { MovieId = 17, Length = 125, Title = "Titanic", Genre = "Romance", MainActress = "Kate Winslet", DateRelease = new DateTime(1997, 12, 19), Description = "A seventeen-year-old aristocrat falls in love with a kind but poor artist aboard the luxurious, ill-fated R.M.S. Titanic", ImageUrl = "Titanic.jpg", ImdbUrl = "https://www.imdb.com/title/tt0120338/" },
					new Movie { MovieId = 18, Length = 105, Title = "Inglorious Basterds", Genre = "Action", MainActress = "Diane Kruger", DateRelease = new DateTime(2009, 08, 21), Description = "In Nazi-occupied France during World War II, a plan to assasinate Nazi leaders by a group of Jewish U.S. soldiers coincides with a theatre owner's vengeful plans for the same", ImageUrl = "InBasterds.jpg", ImdbUrl = "https://www.imdb.com/title/tt0361748/" },
					new Movie { MovieId = 19, Length = 135, Title = "Star Trek - Into Darkness", Genre = "Sci-Fi", MainActress = "Zoe Saldana", DateRelease = new DateTime(2013, 05, 16), Description = "After the crew of the Enterprise find an unstoppable force of terror from within their own organization, Captain Kirk leads a manhunt to a war-zone world to capture a one-man weapon of mass destruction", ImageUrl = "StarTrek.jpg", ImdbUrl = "https://www.imdb.com/title/tt1408101/" },
					new Movie { MovieId = 20, Length = 110, Title = "Top Gun", Genre = "Action-Drama", MainActress = "Kelly McGills", DateRelease = new DateTime(1986, 05, 16), Description = "As students at the United States Navy's elite fighter weapons school compete to be best in the class, one daring young pilot learns a few things from a civilian instructor that are not taught in the classroom.", ImageUrl = "topgun.jpg", ImdbUrl = "https://www.imdb.com/title/tt0092099/" },
					new Movie { MovieId = 21, Length = 125, Title = "Titanic", Genre = "Romance", MainActress = "Kate Winslet", DateRelease = new DateTime(1997, 12, 19), Description = "A seventeen-year-old aristocrat falls in love with a kind but poor artist aboard the luxurious, ill-fated R.M.S. Titanic", ImageUrl = "Titanic.jpg", ImdbUrl = "https://www.imdb.com/title/tt0120338/" },
					new Movie { MovieId = 22, Length = 105, Title = "Inglorious Basterds", Genre = "Action", MainActress = "Diane Kruger", DateRelease = new DateTime(2009, 08, 21), Description = "In Nazi-occupied France during World War II, a plan to assasinate Nazi leaders by a group of Jewish U.S. soldiers coincides with a theatre owner's vengeful plans for the same", ImageUrl = "InBasterds.jpg", ImdbUrl = "https://www.imdb.com/title/tt0361748/" },
					new Movie { MovieId = 23, Length = 135, Title = "Star Trek - Into Darkness", Genre = "Sci-Fi", MainActress = "Zoe Saldana", DateRelease = new DateTime(2013, 05, 16), Description = "After the crew of the Enterprise find an unstoppable force of terror from within their own organization, Captain Kirk leads a manhunt to a war-zone world to capture a one-man weapon of mass destruction", ImageUrl = "StarTrek.jpg", ImdbUrl = "https://www.imdb.com/title/tt1408101/" },
                    new Movie { MovieId = 24, Length = 110, Title = "Top Gun", Genre = "Action-Drama", MainActress = "Kelly McGills", DateRelease = new DateTime(1986, 05, 16), Description = "As students at the United States Navy's elite fighter weapons school compete to be best in the class, one daring young pilot learns a few things from a civilian instructor that are not taught in the classroom.", ImageUrl = "topgun.jpg", ImdbUrl = "https://www.imdb.com/title/tt0092099/" }
                );

			modelBuilder.Entity<PaymentType>()
				.HasData(
					new PaymentType { PaymentTypeId = 1, TypeOfPayment="VisaCard"},
					new PaymentType { PaymentTypeId = 2, TypeOfPayment = "PayPAl" },
					new PaymentType { PaymentTypeId=3,TypeOfPayment="Boncontact"}
				);

			modelBuilder.Entity<Renter>()
				.HasData(
					new Renter { RenterId = 1, FirstName = "Fatih", LastName = "Ozer",IdPaymentType=1 },
					new Renter { RenterId = 2, FirstName = "Anass", LastName = "Allamzi",IdPaymentType=2 },
					new Renter { RenterId = 3, FirstName = "Olga", LastName = "Kharchuk" ,IdPaymentType=3}
				);
			modelBuilder.Entity<RentMovie>()
				.HasData(
					new RentMovie { RentMovieId = 1, MovieId=  1, RenterId=1},
					new RentMovie { RentMovieId = 2, MovieId = 1, RenterId = 2 },
					new RentMovie { RentMovieId = 3, MovieId = 2, RenterId = 2 },
					new RentMovie { RentMovieId = 4, MovieId = 2, RenterId = 1 },
					new RentMovie { RentMovieId = 6, MovieId = 3, RenterId = 3 },
					new RentMovie { RentMovieId = 7, MovieId = 5, RenterId = 3 }
				);
			modelBuilder.Entity<RentMovie>()
			   .HasKey(ab => new { ab.MovieId, ab.RenterId });

			//setup one-to-many rel authorsbook => books
			modelBuilder.Entity<RentMovie>()
				.HasOne<Movie>(ab => ab.Movie)
				.WithMany(b => b.RentMovies)
				.HasForeignKey(b => b.MovieId);

			// setup one-to-many rel authorsbook => author
			modelBuilder.Entity<RentMovie>()
			  .HasOne<Renter>(ab => ab.Renter)
			  .WithMany(b => b.RentMovies)
			  .HasForeignKey(b => b.RenterId);
		}

		public DbSet<Movie> Movies { get; set; }
		public DbSet<Renter> Renters { get; set; }
		public DbSet<PaymentType> PaymentTypes { get; set; }
		public DbSet<RentMovie> RentMovies { get; set; }
	}
}
