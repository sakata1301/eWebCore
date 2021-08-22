using eWebCore.ViewModels.Catalog.Product;
using eWebCore.ViewModels.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eWebCore.Application.Catalog.ProductFolder
{
    public interface IPublicProductService
    {
        Task<PagingResult<ProductViewModel>> GetProductByCategory(GetPublicProductPagingRequest request);
    }
}
