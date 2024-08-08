using APIROBERTO.Models.DCModel;
using Microsoft.EntityFrameworkCore;

namespace APIROBERTO.Models
{
    public class DCcontext : DbContext
    {
        public DCcontext(DbContextOptions<DCcontext> options): base(options) {}
        public DbSet<Aspirante> Aspirantes { get; set; }
    }
}