using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BMB_Services.DTOs;

namespace BMB_Services.Interfaces
{
    public interface IUserService
    {
        Task<LoginResponseModel?> LoginAsync(string email, string password);
        Task<bool> RegisterAsync(string username, string email, string password);
    }
}
