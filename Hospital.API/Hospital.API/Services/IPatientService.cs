using Hospital.API.Services.Dto;

namespace Hospital.API.Services
{
    public interface IPatientService
    {
        Task<bool> Create(RegisterPatientDto dto);
    }
}
