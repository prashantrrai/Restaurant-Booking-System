namespace RestaurantBooking.Web.Models
{
    public class HomeViewModel
    {
        public string BannerImage { get; set; } = "https://graphicsfamily.com/wp-content/uploads/edd/2023/09/Restaurant-food-menu-web-banner-template-scaled.jpg";
        public string SearchQuery { get; set; }
        public List<Restaurant> Restaurants { get; set; }
        public List<Testimonial> Testimonials { get; set; }
    }

    public class Restaurant
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public decimal Rating { get; set; }
        public string  Review { get; set; }
    }

    public class Testimonial
    {
        public string Name { get; set; }
        public string Feedback { get; set; }
    }
}
