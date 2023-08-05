﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Application.Models
{

    public class LoginRequest
    {
        public int SicilNo { get; set; }
        public string Sifre { get; set; }
    }
    public class LoginResponse
    {
        public bool IsManager { get; set; }
        public bool IsSuccessfull { get; set; }
        public string Message { get; set; }
        public bool IsBirthday { get; set; }
    }


}
