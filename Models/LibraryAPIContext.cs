using Microsoft.EntityFrameworkCore;


namespace LibraryAPI.Models
{
    public class LibraryAPIContext : DbContext
    {
        public LibraryAPIContext(DbContextOptions<LibraryAPIContext> options)
            : base(options)
        {
        }

            public DbSet<Genre> Genres { get; set; }
            public DbSet<Story> Stories { get; set; }
            protected override void OnModelCreating(ModelBuilder builder)
            {
                builder.Entity<Genre>()
                    .HasData(
                        new Genre { GenreId = 1, GenreName = " Horror ", GenreDescription = " A Collection of Short Horror Stories"  },
                        new Genre { GenreId = 2, GenreName = " Comedy ", GenreDescription = " A Collection of Short Comedic Stories "},
                        new Genre { GenreId = 3, GenreName = " Drama ", GenreDescription = " A Collection of Short Drama Stories "},
                        new Genre { GenreId = 4, GenreName = " Adventure ", GenreDescription = " A Collection of Short Adventure Stories" }, 
                        new Genre { GenreId = 5, GenreName = " Suspenseful ", GenreDescription = " A Collection of Short Suspenseful Stories "},
                        new Genre { GenreId = 6, GenreName = " Poems ", GenreDescription = " A Collection of Short Poems "}
                    );
                    builder.Entity<Story>()
                        .HasData(
                            new Story { StoryId = 1, StoryName = "Id Love To Have An Adventure", StoryDetails = " Id love to have an adventure " + " To different worlds where my heart can fly " + " To different worlds where my heart desires " + " And will be remembered until I die. " + " Id love to have an adventure " + " Along with my precious pen " + " And write down all the things Ive witnessed " + " And read it all again. " + " Id love to have an adventure " + " Through the darkest part of the forest " + " And meet the greatest beasts " + " And see who is the toughest. " + " Id love to have an adventure " + " Through the deepest part of the sea " + " Where a place I can find peace " + " As if there is no living creature but me. " + " Id love to have an adventure " + " Where mysterious mountains hide secrets " + " Then Ill climb to its toppest part " + " By ignoring the chirping crickets. " + " Id love to have an adventure " + " Where I can be my fullest self " +  " Together with my loved ones " + " And finish the books on the shelf. " + " Id love to have an adventure " + " With my eyes that is sharper than knife " + " Ill face my battles, brave and humble " +" Until I get to the Everlasting Life " },

                            new Story  { StoryId = 2, StoryName = "Octobers Gold", StoryDetails = " Like crunchy cornflakes " + " Gold leaves rustle underfoot " + " Beauty in decay. "},

                            new Story { StoryId = 3, StoryName = "The Accident", StoryDetails = " It was one a.m. and Guy Halverson sat in his dark living room. He hadn't moved for over an hour. The accident earlier that evening kept playing over and over in his mind. The light turned red, but he was in a hurry and accelerated. An orange blur came from his right, and in a split second there was a violent jolt, then the bicyclist rolled across his hood and fell out of sight on the pavement. Horns blared angrily and he panicked, stepping on the gas and screeching away from the chaos into the darkness, shaken and keeping an eye on his rearview mirror until he got home.Why did you run, you idiot? He'd never committed a crime before this and punished himself by imagining years in jail, his career gone, his family gone, his future gone.Why not just go to the police right now? You can afford a lawyer.Then someone tapped on the front door and his world suddenly crumbled away beneath him. They found me. There was nothing he could do but answer it. Running would only make matters worse. His body trembling, he got up, went to the door and opened it. A police officer stood under the porch light." + " Mr. Halverson? " + " asked the grim officer.He let out a defeated sigh." + " Yes. Let me — " + " I am terribly sorry, but I'm afraid I have some bad news. Your son's bike was struck by a hit and run driver this evening. He died at the scene. I'm very sorry for your loss."}
                        );
            }
    }
}