using Microsoft.EntityFrameworkCore;
using TraversalApiProject.DAL.Entities;

namespace TraversalApiProject.DAL.Context
{
    public class VisitorContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-5EPP4QL;Database=TraversalDBApi;Trusted_Connection=True;TrustServerCertificate=True;");
        }

        public DbSet<Visitor> Visitors { get; set; }
    }
}
