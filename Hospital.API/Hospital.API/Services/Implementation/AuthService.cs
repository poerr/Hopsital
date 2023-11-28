using Hospital.API.Services.Dto;
using Microsoft.AspNetCore.Identity;
using Hospital.API.Shared;
using AutoMapper;
using Hospital.API.Models;

namespace Hospital.API.Services.Implementation
{
    public class AuthService : IAuthService
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly IPatientService _patientService;
        public AuthService(
            UserManager<IdentityUser> userManager,
            IPatientService patientService
            )
        {
            _userManager = userManager;
            _patientService = patientService;
        }

        public async Task<bool> RegisterPatient(RegisterPatientDto dto)
        {
            var identityUser = new IdentityUser
            {
                UserName = dto.Email,
                Email = dto.Email,
            };

            var identityResult = await _userManager.CreateAsync(identityUser, dto.Password);

            if(identityResult.Succeeded)
            {
                identityResult = await _userManager.AddToRoleAsync(identityUser, Constants.PATIENT_ROLE);

                if(identityResult.Succeeded)
                {
                    return await _patientService.Create(dto);
                }
            }
            return false;
        }
    }
}
