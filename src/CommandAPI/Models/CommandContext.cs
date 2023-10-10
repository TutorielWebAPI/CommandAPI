using Microsoft.EntityFrameworkCore;

namespace CommandAPI.Models
{
    public class CommandContext:DbContext
    {
        public CommandContext(DbContextOptions options) : base(options)
        {

        }   
        public DbSet<Command> CommandItems{ get; set; }
        
    }
}