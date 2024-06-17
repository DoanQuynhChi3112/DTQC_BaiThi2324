using DTQC_BaiThi2324.Models;
using Microsoft.EntityFrameworkCore;

namespace DTQC_BaiThi2324.Data

{
    public class ApplicationDbcontext : DbContext 
    {
        public ApplicationDbcontext(DbContextOptions<ApplicationDbcontext> options) : base(options)
        {}
        public DbSet<DTQC114Person> DTQC114Person { get; set;}
        public DbSet<DTQC_BaiThi2324.Models.DTQC114Student> DTQC114Student { get; set; } = default!;
        public DbSet<DTQC_BaiThi2324.Models.DTQC114Employee> DTQC114Employee { get; set; } = default!;
      
    }
}