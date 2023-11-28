using Hospital.API.Data;
using Hospital.API.Models;
using Microsoft.EntityFrameworkCore;

namespace Hospital.API.Repositories.Implementation
{
    public class PatientRepository : IPatientRepository
    {
        private readonly HospitalDbContext _context;
        public PatientRepository(
            HospitalDbContext context
            )
        {
            _context = context;
        }

        public async Task<Patient?> GetById(int id)
        {
            return await _context.Patients.FirstOrDefaultAsync(x => x.Id == id);
        }
        public async Task<Patient?> GetByEmail(string email)
        {
            return await _context.Patients.FirstOrDefaultAsync(x => x.Email == email);
        }
        public async Task<bool> Create(Patient patient)
        {
            try
            {
                await _context.AddAsync(patient);
                await _context.SaveChangesAsync();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public async Task<Patient?> Update(Patient patient)
        {
            _context.Update(patient);
            await _context.SaveChangesAsync();
            return patient;

        }
        public async Task<bool> Delete(Patient patient)
        {
            _context.Patients.Remove(patient);
            await _context.SaveChangesAsync();
            return true;
        }
    }
}
