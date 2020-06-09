using Microsoft.EntityFrameworkCore;

namespace LibraryAPI.Models
{
    public class LibraryAPIContext : DbContext
    {
        public TravelAPIContext(DbContextOptions<LibraryAPIContext> options)
            : base(options)
        {
        }

            public DbSet<Genre> Genres { get; set; }
            public DbSet<Story> Stories { get; set; }
            protected override void OnModelCreating(ModelBuilder builder)
            {
                builder.Entity<Genre>()
                    .HasDate(
                        new Genre { GenreId = 1, GenreName = "Horror", GenreDescription = "A Collection of Short Horror Stories"  },
                        new Genre { GenreId = 2, GenreName = "Comedy" GenreDescription = "A Collection of Short Comedic Stories"},
                        new Genre { GenreId = 3, GenreName = "Drama" GenreDescription = "A Collection of Short Drama Stories"},
                        new Genre { GenreId = 4, GenreName = "Adventure"GenreDescription = "A Collection of Short Adventure Stories" }, 
                        new Genre { GenreId = 5, GenreName = "Suspenseful" GenreDescription = "A Collection of Short Suspenseful Stories"},
                        new Genre { GenreId = 6, GenreName = "Romance" GenreDescription = "A Collection of Short Romance Stories"}
                    );
                    builder.Entity<Story>()
                        .HasData(
                            new Story { StoryId = 1, StoryName = "Id Love To Have An Adventure", StoryDetails = "Id love to have an adventure" + "To different worlds where my heart can fly" +
                                                                                                "To different worlds where my heart desires" +
                                                                                                "And will be remembered until I die." +

                                                                                                "Id love to have an adventure" +
                                                                                                "Along with my precious pen" +
                                                                                                
                                                                                                "And write down all the things Ive witnessed" +
                                                                                                "And read it all again." +

                                                                                                "Id love to have an adventure" +
                                                                                                "Through the darkest part of the forest" +
                                                                                                "And meet the greatest beasts" +
                                                                                                "And see who is the toughest." +

                                                                                                "Id love to have an adventure" +
                                                                                                "Through the deepest part of the sea" +
                                                                                                "Where a place I can find peace" +
                                                                                                "As if there is no living creature but me." +

                                                                                                "Id love to have an adventure" +
                                                                                                "Where mysterious mountains hide secrets" +
                                                                                                "Then Ill climb to its toppest part" +
                                                                                                "By ignoring the chirping crickets." +

                                                                                                "Id love to have an adventure" +
                                                                                                "Where I can be my fullest self" +
                                                                                                "Together with my loved ones" +
                                                                                                "And finish the books on the shelf." +

                                                                                                "Id love to have an adventure"
                                                                                                "With my eyes that is sharper than knife" +
                                                                                                "Ill face my battles, brave and humble" +
                                                                                                "Until I get to the Everlasting Life" }
                        )
            }
    }
}