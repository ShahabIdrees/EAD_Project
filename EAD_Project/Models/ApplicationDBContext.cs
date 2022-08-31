using Microsoft.EntityFrameworkCore;
namespace EAD_Project.Models
{
    public class ApplicationDBContext : DbContext
    {
        DbSet<User> users { get; set; }//TABEL NAME>
        public ApplicationDBContext()
        {

        }
        public ApplicationDBContext(DbContextOptions options):base(options)
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=USER;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        
        }
    }
}
