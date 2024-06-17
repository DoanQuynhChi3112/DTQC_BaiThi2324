using DTQC_BaiThi2324.Models;
using Microsoft.EntityFrameworkCore;

namespace DTQC_BaiThi2324.Data

{
    public class ApplicationDbcontext : DbContext 
    {
        public ApplicationDbcontext(DbContextOptions<ApplicationDbcontext> options) : base(options)
        {}
        public DbSet<DTQC114Person> DTQC114Person { get; set;}
      
    }
}