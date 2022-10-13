using System.ComponentModel.DataAnnotations;

namespace MoviesWebsiteMVC.Models
{
    public class Actor
    {
        [Key]
        public int Id { get; set; }

        [Display(Name= "Profile Picture URL")]
        public string profilePictureURL { get; set; }

        [Display(Name = "Full Name")]
        public string FullName { get; set; }

        [Display(Name = "Bio")]
        public string Bio { get; set; }

        //Realationships 
        public List<Actor_Movie> Actors_Movies { get; set; }
    }
}
