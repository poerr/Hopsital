using Microsoft.EntityFrameworkCore;

namespace Hospital.API.Data
{
    public class HospitalDbContext : DbContext
    {
        public HospitalDbContext(DbContextOptions<HospitalDbContext> options) : base(options)
        {
            
        }
    }
}
