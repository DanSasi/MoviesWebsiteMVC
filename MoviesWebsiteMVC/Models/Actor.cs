using System.ComponentModel.DataAnnotations;

namespace MoviesWebsiteMVC.Models
{
    public class Actor
    {
        [Key]
        public int Id { get; set; }
        public string profilePictureURL { get; set; }
        public string FullName { get; set; }
        public string Bio { get; set; }

        //Realationships 
        public List<Actor_Movie> Actors_Movies { get; set; }
    }
}
