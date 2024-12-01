﻿namespace Talabat.API.Controllers
{
    public class AuthenticationController : ApiBaseController
    {
        private readonly IAuthenticationService _authenticationService;
        public AuthenticationController(IAuthenticationService authenticationService)
        {
            _authenticationService = authenticationService;
        }

        [HttpPost("Login")]
        public async Task<LoginResponse> Login(LoginRequest loginRequest)
        {
            return await _authenticationService.Login(loginRequest);
        }

        [HttpPost("Register")]
        public async Task<IActionResult> Register(RegisterRequest registerRequest)
        {
            await _authenticationService.Register(registerRequest);

            return Ok();
        }

        [HttpPost("confirm-email")]
        public async Task<IActionResult> ConfirmEmailAsync([FromQuery]ConfirmEmailRequest request)
        {
            await _authenticationService.ConfirmEmailAsync(request);

            return Ok();
        }

        [HttpPost("resend-confirmation-email")]
        public async Task<IActionResult> ResendConfirmationEmail(ResendConfirmationEmailRequest request)
        {
            await _authenticationService.ResendConfirmationEmail(request);
            
            return Ok();
        }
     

        [HttpPost("forgot-password")]
        public async Task<IActionResult> ForgetPasswordAsync(ForgetPasswordRequest request)
        {
            await _authenticationService.ForgetPasswordAsync(request);

            return Ok();
        }

        [HttpPost("reset-password")]
        public async Task<IActionResult> ResetPasswordAsync(ResetPasswordRequest request)
        {
            await _authenticationService.ResetPasswordAsync(request);

            return Ok();
        }

        [HttpPost("refresh-token")]
        public async Task<LoginResponse?> RefreshTokenAsync(RefreshTokenRequest request)
        {
            return await _authenticationService.GetRefreshToken(request.AccessToken, request.RefreshToken);
        }


        [HttpPost("revoke-token")]
        public async Task<bool> RevokeRefreshToken(RefreshTokenRequest request)
        {
           return await _authenticationService.RevokeRefreshToken(request.AccessToken,request.RefreshToken);
        }
    }
}
