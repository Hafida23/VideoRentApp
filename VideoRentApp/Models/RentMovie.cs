namespace VideoRentApp.Models
{
    public class RentMovie
    {
        public int RentMovieId { get; set; }
        public int MovieId { get; set;}
        public Movie Movie { get; set; }
        public int RenterId { get; set; }
        public Renter Renter { get; set; }
       

    }
}
