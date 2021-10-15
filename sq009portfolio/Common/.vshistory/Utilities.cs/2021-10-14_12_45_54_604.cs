using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace portfolio.Common
{
    public static class Utilities
    {
        public static ResponseDto<T> CreateResponse<T>(string message, T data)
        {
            var obj = new ResponseDto<T>()
            {
                Message = message,
                Data = data
            };
            return obj;
        }
    }
}
