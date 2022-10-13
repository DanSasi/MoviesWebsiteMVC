using System.ComponentModel.DataAnnotations;

namespace MoviesWebsiteMVC.Models
{
    public class Producer
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Profile Picture")]
        public string profilePictureURL { get; set; }

        [Display(Name = "Full Name")]
        public string FullName { get; set; }

        [Display(Name = "Biography")]
        public string Bio { get; set; }

        //Realationships 

        public List<Movie> movies { get; set; }

    }
}
