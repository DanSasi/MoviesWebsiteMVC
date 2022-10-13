using System.ComponentModel.DataAnnotations;

namespace MoviesWebsiteMVC.Models
{
    public class Cinema
    {
        [Key]
        public int Id { get; set; }


        [Display(Name = "Logo Picture")] 
        public string Logo { get; set; }

        [Display(Name = "Name")]
        public string Name { get; set; }

        [Display(Name = "Description")]
        public string Description { get; set; }

        //Realationships 
        public List<Movie> movies { get; set; }
    }
}
