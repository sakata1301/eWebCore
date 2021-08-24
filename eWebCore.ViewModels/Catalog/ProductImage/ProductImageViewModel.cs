﻿using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eWebCore.ViewModels.Catalog.ProductImage
{
    public class ProductImageViewModel
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public string ImagePath { get; set; }
        public string Caption { get; set; }
        public bool IsDefalt { set; get; }
        public DateTime DateCreated { set; get; }
        public int SortOrder { set; get; }
        public long FileSize { set; get; }
    }
}
