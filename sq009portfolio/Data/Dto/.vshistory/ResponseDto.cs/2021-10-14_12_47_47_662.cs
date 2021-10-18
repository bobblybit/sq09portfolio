﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace portfolio.Data.Dto
{
    public class ResponseDto<T>
    {
        public string Message { get; set; }
        public T Data { get; set; }
    }
}
