using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace LibraryAPI.Models
{
    public class Genre
    {
        public int GenreId { get; set;}
        public string GenreName { get; set; }
        public string GenreDescription { get; set; }

        public virtual ICollection<StoryGenre> Stories { get; set; }
        
        public Genre()
        {
            this.Stories = new HashSet<StoryGenre>();
        }

    }
    
}