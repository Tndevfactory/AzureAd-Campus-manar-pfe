using Microsoft.EntityFrameworkCore;


namespace tracerapi.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<TracerModel> TracerModels { get; set; }
    }
}
