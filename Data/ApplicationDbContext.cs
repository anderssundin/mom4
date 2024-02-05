using Microsoft.EntityFrameworkCore;
using mom4.Models;

namespace mom4.Data{

    public class ApplicationDbContext : DbContext {
        

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) {

        }

        public DbSet<SongModel> Songs {get; set;}

        public DbSet<CommentModel> Comments {get; set;}
    }
}