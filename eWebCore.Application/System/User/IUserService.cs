﻿using eWebCore.ViewModels.Common;
using eWebCore.ViewModels.System.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eWebCore.Application.System.User
{
    public interface IUserService
    {
        Task<string> Authenticate(LoginRequest request);

        Task<bool> Register(RegisterRequest request);

        Task<PagingResult<UserViewModel>> GetUserPaging(GetUserPagingRequest request);
    }
}