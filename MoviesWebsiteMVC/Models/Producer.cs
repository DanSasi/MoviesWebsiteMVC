using System.ComponentModel.DataAnnotations;

namespace MoviesWebsiteMVC.Models
{
    public class Producer
    {
        [Key]
        public int Id { get; set; }
        public string profilePictureURL { get; set; }
        public string FullName { get; set; }
        public string Bio { get; set; }

        //Realationships 

        public List<Movie> movies { get; set; }

    }
}
