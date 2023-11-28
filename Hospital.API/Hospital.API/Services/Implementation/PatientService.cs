using AutoMapper;
using Hospital.API.Models;
using Hospital.API.Repositories;
using Hospital.API.Services.Dto;

namespace Hospital.API.Services.Implementation
{
    public class PatientService : IPatientService
    {
        private readonly IPatientRepository _patientRepository;
        private readonly IMapper _mapper;
        public PatientService(
            IPatientRepository patientRepository,
            IMapper mapper
            )
        {
            _patientRepository = patientRepository;
            _mapper = mapper;
        }

        public async Task<bool> Create(RegisterPatientDto dto)
        {
            Patient newPatient = _mapper.Map<Patient>(dto);
            newPatient.Address = _mapper.Map<Address>(dto);
            
            return await _patientRepository.Create(newPatient);
        }
    }
}
