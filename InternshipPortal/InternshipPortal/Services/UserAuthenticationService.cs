using Microsoft.AspNetCore.Components.Authorization;

namespace InternshipPortal.Services
{
    public class UserAuthenticationService
    {
        public async Task<bool> GetUserLoginStatus(AuthenticationStateProvider authStateProvider)
        {
            var authState = await authStateProvider.GetAuthenticationStateAsync();
            return authState.User.Identity.IsAuthenticated;
        }

        public async Task<string> GetUserName(AuthenticationStateProvider authStateProvider)
        {
            var authState = await authStateProvider.GetAuthenticationStateAsync();
            return authState.User.Identity.Name;
        }

        public async Task<bool> IsUserInRole(AuthenticationStateProvider authStateProvider, string role)
        {
            var authState = await authStateProvider.GetAuthenticationStateAsync();
            return authState.User.IsInRole(role);
        }
    }
}
