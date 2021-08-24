using eWebCore.ViewModels.Catalog.Product;
using eWebCore.ViewModels.Catalog.ProductImage;
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

        Task<ProductViewModel> GetById(int productId, string languageId);

        Task<int> Update(ProductUpdateReq request);

        Task<int> Delete(int id);

        Task<bool> UpdatePrice(int productId, decimal newPrice);

        Task<bool> UpdateStock(int productId, int addedQuantity);

        Task AddViewCount(int productId);

        Task<List<ProductViewModel>> GetAll();

        Task<int> AddImage(int productId, ProductImageCreateRequest request);

        Task<ProductImageViewModel> GetImageById(int productId, int imageId);

        Task<int> RemoveImage(int productId, int imageId);

        Task<int> UpdateImage(int productId, int imageId, ProductImageUpdateRequest request);

        Task<List<ProductImageViewModel>> GetListImages(int productId);

        //Get Phan tu cho phan trang
        Task<PagingResult<ProductViewModel>> GetAllPaging(GetManageProductPagingRequest request);
    }
}