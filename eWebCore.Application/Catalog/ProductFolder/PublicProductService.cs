using eWebCore.Data.EF;
using eWebCore.ViewModels.Catalog.Product;
using eWebCore.ViewModels.Common;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eWebCore.Application.Catalog.ProductFolder
{
    public class PublicProductService : IPublicProductService
    {
        private readonly EWebCoreDbContext _context;

        public PublicProductService(EWebCoreDbContext context)
        {
            _context = context;
        }
        public async Task<PagingResult<ProductViewModel>> GetProductByCategory(GetPublicProductPagingRequest request)
        {
            var query = from p in _context.Products
                        join pt in _context.ProductTranslations on p.Id equals pt.ProductId
                        join pic in _context.ProductInCategories on p.Id equals pic.ProductId
                        join c in _context.Categories on pic.CategoryId equals c.Id
                        select new { p, pt, pic };

            if (request.CategoryId.Value > 0 && request.CategoryId.HasValue)
            {
                query = query.Where(p => request.CategoryId == p.pic.CategoryId);
            }

            int totalRow = await query.CountAsync();
            var data = await query.Skip((request.PageIndex - 1) * request.PageSize).Take(request.PageSize)
                .Select(x => new ProductViewModel()
                {
                    Id = x.p.Id,
                    Name = x.pt.Name,
                    DateCreated = x.p.DateCreated,
                    Description = x.pt.Description,
                    Details = x.pt.Details,
                    LanguageId = x.pt.LanguageId,
                    OriginalPrice = x.p.OriginalPrice,
                    Price = x.p.Price,
                    SeoAlias = x.p.SeoAlias,
                    SeoDescription = x.pt.Description,
                    SeoTitle = x.pt.SeoTitle,
                    Stock = x.p.Stock,
                    ViewCount = x.p.ViewCount
                }).ToListAsync();

            var pageResult = new PagingResult<ProductViewModel>()
            {
                TotalRecord = totalRow,
                items = data
            };

            return pageResult;
        }
    }
}
