using eWebCore.ViewModels.Common;
using eWebCore.ViewModels.System.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eWebCore.AdminApp.Services
{
    public interface IUserApiClient
    {
        Task<string> Authenticate(LoginRequest request);

        Task<PagingResult<UserViewModel>> GetUserPaging(GetUserPagingRequest request);
    }
}