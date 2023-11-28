using Hospital.API.Services.Dto;
using Microsoft.AspNetCore.Identity;
using Hospital.API.Shared;
using AutoMapper;
using Hospital.API.Models;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Hospital.API.Services.Implementation
{
    public class AuthService : IAuthService
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly IPatientService _patientService;
        private readonly ITokenService _tokenService;
        private readonly IMapper _mapper;
        public AuthService(
            UserManager<IdentityUser> userManager,
            IPatientService patientService,
            ITokenService tokenService,
            IMapper mapper
            )
        {
            _userManager = userManager;
            _patientService = patientService;
            _mapper = mapper;
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

        public async Task<UserDto?> Login(LoginDto dto)
        {
            var user = await _userManager.FindByEmailAsync(dto.Email);
            if(user != null)
            {
                var checkPasswordResult = await _userManager.CheckPasswordAsync(user, dto.Password);
                if(checkPasswordResult)
                {
                    var role = await _userManager.GetRolesAsync(user);

                    if (role[0] == Constants.PATIENT_ROLE)
                    {
                        var patient = await _patientService.GetByEmail(dto.Email);
                        if(patient != null)
                        {
                            UserDto userData = _mapper.Map<UserDto>(patient);
                            userData.Token = _tokenService.CreateJWTToken(user, role[0]);
                            return userData;
                        }
                    }
                    else if (role[0] == Constants.DOCTOR_ROLE)
                    {

                    }
                    else if (role[0] == Constants.MANAGER_ROLE)
                    {
                        
                    }
                    else
                    {
                        return null;
                    }
                }
            }
            return null;
        }
    }
}
