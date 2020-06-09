using System.Collections.Generic;

namespace LibraryAPI.Models
{
    public class Story
    {
        public int StoryId { get; set; }
        public string StoryName { get; set; }
        public string StoryDetails { get; set; }

        public virtual ICollection<StoryGenre> Genres { get; set; }

        public Story()
        {
           this.Genres = new HashSet<StoryGenre>();
        }
    }
}