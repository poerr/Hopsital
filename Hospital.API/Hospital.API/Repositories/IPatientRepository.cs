using Hospital.API.Data;
using Hospital.API.Models;

namespace Hospital.API.Repositories
{
    public interface IPatientRepository
    {
        Task<Patient?> GetById(int id);
        Task<Patient?> GetByEmail(string email);
        Task<bool> Create(Patient patient);
        Task<Patient?> Update(Patient patient);
        Task<bool> Delete(Patient patient);
    }
}
