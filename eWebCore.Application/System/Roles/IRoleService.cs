using eWebCore.ViewModels.Common;
using eWebCore.ViewModels.System.Roles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eWebCore.Application.System.Roles
{
    public interface IRoleService
    {
        Task<List<RoleVM>> GetAll();
    }
}