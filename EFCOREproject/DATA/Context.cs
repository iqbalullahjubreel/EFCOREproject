using Microsoft.EntityFrameworkCore;

public class Context : DbContext
{
    public Context(DbContextOptions dbContextOptions) : base(dbContextOptions)
    {

    }
    public DbSet<PIZZA> Pizzas { get; set; }

}
