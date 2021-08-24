using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eWebCore.ViewModels.Catalog.ProductImage
{
    public class ProductImageUpdateRequest
    {
        public int Id { get; set; }     
        public string Caption { get; set; }
        public bool IsDefalt { set; get; }
        public int SortOrder { set; get; }
        public IFormFile ImageFile { get; set; }
    }
}
