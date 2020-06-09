namespace LibraryAPI.Models
{
    public class StoryGenre
    {
        public int StoryGenreId { get; set; }
        public int StoryId { get; set; }
        public int GenreId { get; set; }
        public Story Story { get; set; }
        public Genre Genre { get; set; }
    }
}