using Microsoft.EntityFrameworkCore;
using MVCYoutubeProject.Models;
namespace MVCYoutubeProject.Data;
#nullable disable

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
        
    }

    public DbSet<Category> Categories { get; set; }


}
