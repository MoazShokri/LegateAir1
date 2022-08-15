using LegateAirLine.Models;
using Microsoft.AspNetCore.Identity;

namespace LegateAirLine.Services
{
    public interface IAccountServices
    {
        Task<AuthModel> RegisterAsync(RegisterModel model);
        Task<AuthModel> GetTokenAsync(TokenRequestModel model);
        Task<string> AddRoleAsync(AddRoleModel model);

    }
}
