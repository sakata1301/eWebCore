using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eWebCore.ViewModels.Common
{
    public class ApiSuccsessResult<T> : ApiResult<T>
    {
        public ApiSuccsessResult()
        {
            IsSuccessed = true;
        }

        public ApiSuccsessResult(T objResult)
        {
            IsSuccessed = true;
            ObjResult = objResult;
        }
    }
}