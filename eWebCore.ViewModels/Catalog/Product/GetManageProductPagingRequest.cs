using eWebCore.ViewModels.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eWebCore.ViewModels.Catalog.Product
{
    public class GetManageProductPagingRequest : PagingRequestBase
    {
        public string Keyword { get; set; }
        public List<int> CategoryIds { get; set; }
    }
}
