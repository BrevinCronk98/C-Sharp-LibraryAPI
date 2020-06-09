using System.Collection.Generic;

namespace LibraryAPI.Models
{
    public class Story
    {
        public int StoryId { get; set; }
        public string StoryName { get; set; }
        public string StoryDetails { get; set; }

        public virtual ICollection<Genre> Genres { get; set; }

        public Story()
        {
            Genres = new HashSet<Genre>();
        }
    }
}