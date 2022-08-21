using API.Entities;
using Microsoft.EntityFrameworkCore;

namespace API.Data
{

    public class AppDbContext : DbContext
    {


        public DbSet<Supplier> Supplier { get; set; }


        public AppDbContext(DbContextOptions options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity(typeof(Supplier)).HasData(
            new Supplier()
            {
                Id = 1,
                FirstName = "behzad",
                LastName= "eskandari",
            },
            new Supplier()
            {
                Id =2,
                FirstName = "majid",
                LastName = "majidi",
            },
            new Supplier()
            {
                Id = 3,
                FirstName = "hasan",
                LastName = "hasani",
            },
            new Supplier()
            {
                Id = 4,
                FirstName = "reza",
                LastName = "nazari",
            },
            new Supplier()
            {
                Id = 5,
                FirstName = "hasan",
                LastName = "nazari",
            },
            new Supplier()
            {
                Id = 6,
                FirstName = "nazari",
                LastName = "majid",
            },
            new Supplier()
            {
                Id = 7,
                FirstName = "reza",
                LastName = "nazari",
            },
            new Supplier()
            {
                Id =8,
                FirstName = "javad",
                LastName = "nazari",
            },
            new Supplier()
            {
                Id = 9,
                FirstName = "behzad",
                LastName = "behzadi",
            }, 
            new Supplier()
            {
                Id = 10,
                FirstName = "reza",
                LastName = "majidi",
            },
            new Supplier()
            {
                Id = 11,
                FirstName = "hasan",
                LastName = "majidi",
            },
            new Supplier()
            {
                Id = 12,
                FirstName = "abas",
                LastName = "majidi",
            },
            new Supplier()
            {
                Id = 13,
                FirstName = "reza",
                LastName = "majidi",
            },
            new Supplier()
            {
                Id = 14,
                FirstName = "mehdi",
                LastName = "majidi",
            },
            new Supplier()
            {
                Id = 15,
                FirstName = "javad",
                LastName = "majidi",
            },
            new Supplier()
            {
                Id = 16,
                FirstName = "nabi",
                LastName = "majidi",
            },
            new Supplier()
            {
                Id = 17,
                FirstName = "asghar",
                LastName = "majidi",
            },
            new Supplier()
            {
                Id = 18,
                FirstName = "frozan",
                LastName = "frozan",
            },
            new Supplier()
            {
                Id = 19,
                FirstName = "mehdi",
                LastName = "frozan",
            },
            new Supplier()
            {
                Id = 20,
                FirstName = "behzad",
                LastName = "frozan",
            },
            new Supplier()
            {
                Id = 21,
                FirstName = "reza",
                LastName = "frozan",
            },
            new Supplier()
            {
                Id = 22,
                FirstName = "majid",
                LastName = "frozan",
            },
            new Supplier()
            {
                Id = 23,
                FirstName = "javad",
                LastName = "frozan",
            },
            new Supplier()
            {
                Id = 24,
                FirstName = "keyval",
                LastName = "frozan",
            },
            new Supplier()
            {
                Id = 25,
                FirstName = "ali",
                LastName = "frozan",
            },
            new Supplier()
            {
                Id = 26,
                FirstName = "ali",
                LastName = "vedadi",
            },
            new Supplier()
            {
                Id = 27,
                FirstName = "keyvan",
                LastName = "vedadi",
            },
            new Supplier()
            {
                Id = 28,
                FirstName = "hesam",
                LastName = "vedadi",
            },
            new Supplier()
            {
                Id = 29,
                FirstName = "behzad",
                LastName = "vedadi",
            },
            new Supplier()
            {
                Id = 30,
                FirstName = "reza",
                LastName = "vedadi",
            },
            new Supplier()
            {
                Id = 31,
                FirstName = "jaavad",
                LastName = "vedadi",
            },
            new Supplier()
            {
                Id = 32,
                FirstName = "majid",
                LastName = "vedadi",
            },
            new Supplier()
            {
                Id = 33,
                FirstName = "hasan",
                LastName = "vedadi",
            },
            new Supplier()
            {
                Id = 34,
                FirstName = "abbas",
                LastName = "vedadi",
            },
            new Supplier()
            {
                Id = 35,
                FirstName = "reza",
                LastName = "javani",
            },
            new Supplier()
            {
                Id = 36,
                FirstName = "mehdi",
                LastName = "javani",
            },
            new Supplier()
            {
                Id = 37,
                FirstName = "hasan",
                LastName = "javani",
            },
            new Supplier()
            {
                Id = 38,
                FirstName = "majid",
                LastName = "javani",
            },
            new Supplier()
            {
                Id = 39,
                FirstName = "javad",
                LastName = "javani",
            },
            new Supplier()
            {
                Id = 40,
                FirstName = "mehdi",
                LastName = "javani",
            },
            new Supplier()
            {
                Id = 41,
                FirstName = "morteza",
                LastName = "javani",
            },
            new Supplier()
            {
                Id = 42,
                FirstName = "mojtaba",
                LastName = "javani",
            },
            new Supplier()
            {
                Id = 43,
                FirstName = "amir",
                LastName = "javani",
            },
            new Supplier()
            {
                Id = 44,
                FirstName = "ali",
                LastName = "javani",
            },
            new Supplier()
            {
                Id = 45,
                FirstName = "amirhosen",
                LastName = "javani",
            },
            new Supplier()
            {
                Id = 46,
                FirstName = "saeed",
                LastName = "javani",
            },
            new Supplier()
            {
                Id = 47,
                FirstName = "pejman",
                LastName = "javani",
            },
            new Supplier()
            {
                Id = 48,
                FirstName = "parham",
                LastName = "javani",
            },
            new Supplier()
            {
                Id = 49,
                FirstName = "john",
                LastName = "doe",
            },
            new Supplier()
            {
                Id = 50,
                FirstName = "Jack",
                LastName = "doe",
            },
            new Supplier()
            {
                Id = 51,
                FirstName = "hasan",
                LastName = "revvandi",
            },
            new Supplier()
            {
                Id = 52,
                FirstName = "reza",
                LastName = "revvandi",
            },
            new Supplier()
            {
                Id = 53,
                FirstName = "mehdi",
                LastName = "revvandi",
            },
            new Supplier()
            {
                Id = 54,
                FirstName = "majid",
                LastName = "revvandi",
            },
            new Supplier()
            {
                Id = 55,
                FirstName = "abas",
                LastName = "revvandi",
            },
            new Supplier()
            {
                Id = 56,
                FirstName = "banfshe",
                LastName = "revvandi",
            },
            new Supplier()
            {
                Id = 57,
                FirstName = "asal",
                LastName = "revvandi",
            },
            new Supplier()
            {
                Id = 58,
                FirstName = "maryam",
                LastName = "revvandi",
            },
            new Supplier()
            {
                Id = 59,
                FirstName = "bahare",
                LastName = "revvandi",
            },
            new Supplier()
            {
                Id = 60,
                FirstName = "majidreza",
                LastName = "revvandi",
            }

            );

            base.OnModelCreating(modelBuilder);
        }

    }
}
