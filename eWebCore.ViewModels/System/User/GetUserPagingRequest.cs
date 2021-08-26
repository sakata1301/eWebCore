using eWebCore.ViewModels.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eWebCore.ViewModels.System.User
{
    public class GetUserPagingRequest : PagingRequestBase
    {
        public string KeyWord { get; set; }
    }
}