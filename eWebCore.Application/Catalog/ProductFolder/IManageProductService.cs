using eWebCore.ViewModels.Catalog.Product;
using eWebCore.ViewModels.Common;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eWebCore.Application.Catalog.ProductFolder
{
    public interface IManageProductService
    {
        Task<int> Create(ProductCreateReq request);
        Task<int> Update(ProductUpdateReq request);
        Task<int> Delete(int id);
        Task<bool> UpdatePrice(int productId, decimal newPrice);
        Task<bool> UpdateStock(int productId, int addedQuantity);
        Task AddViewCount(int productId);
        Task<List<ProductViewModel>> GetAll();

        Task<int> AddImage(int productId, List<IFormFile> files);
        Task<int> RemoveImage(int iamgeId);
        Task<int> UpdateImage(int imageId, string caption, bool isDefault);
        //Task<List<ProductViewImageModel>> GetListImage(int productId);
        //Get Phan tu cho phan trang
        Task<PagingResult<ProductViewModel>> GetAllPaging(GetManageProductPagingRequest request);
    }
}
