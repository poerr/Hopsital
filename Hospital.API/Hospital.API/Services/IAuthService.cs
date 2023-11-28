using Hospital.API.Services.Dto;

namespace Hospital.API.Services
{
    public interface IAuthService
    {
        Task<bool> RegisterPatient(RegisterPatientDto dto);
    }
}
