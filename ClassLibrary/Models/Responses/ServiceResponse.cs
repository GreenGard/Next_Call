﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Models.Responses
{
    public class ServiceResponse<T>
    {
      
            public T Data { get; set; }
            public bool Success { get; set; } = true;
            public int StatusCode { get; set; }
            public string Message { get; set; }
        }
    }

