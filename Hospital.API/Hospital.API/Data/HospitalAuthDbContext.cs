using Hospital.API.Shared;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Hospital.API.Data
{
    public class HospitalAuthDbContext : IdentityDbContext
    {
        public HospitalAuthDbContext(DbContextOptions<HospitalAuthDbContext> options) : base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            string doctorRoleId = "5227c7f3-e84d-4d3f-9d59-449a40193eda";
            string patientRoleId = "afa5da7b-3904-474c-9263-939f17617b28";
            string managerRoleId = "d55ad704-d873-45ea-9b58-c29a1d937433";

            var roles = new List<IdentityRole>
            { 
                new()
                {
                    Id = doctorRoleId,
                    ConcurrencyStamp = doctorRoleId,
                    Name = Constants.DOCTOR_ROLE,
                    NormalizedName = Constants.DOCTOR_ROLE.ToUpper(),
                },
                new()
                {
                    Id = patientRoleId,
                    ConcurrencyStamp = patientRoleId,
                    Name = Constants.PATIENT_ROLE,
                    NormalizedName = Constants.PATIENT_ROLE.ToUpper(),
                },
                new()
                {
                    Id = managerRoleId,
                    ConcurrencyStamp = managerRoleId,
                    Name = Constants.MANAGER_ROLE,
                    NormalizedName = Constants.MANAGER_ROLE.ToUpper(),
                }
            };

            builder.Entity<IdentityRole>().HasData(roles);
        }
    }
}
