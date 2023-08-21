using ClassLibrary.Models.EntityModels;
using Microsoft.EntityFrameworkCore;

namespace Next_call.Data
{
    public class DataContext: DbContext
    { 
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        public DbSet<CustomerEntity> Customers { get; set; }

 
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

       
        }
        
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=master;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False", builder =>
        //    {
        //        builder.EnableRetryOnFailure(5, TimeSpan.FromSeconds(10), null);
        //    });
        //    base.OnConfiguring(optionsBuilder);
        //}
    }
}