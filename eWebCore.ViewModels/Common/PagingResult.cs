﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eWebCore.ViewModels.Common
{
    public class PagingResult<T> : PagingResultBase
    {
        public List<T> items { set; get; }
    }
}