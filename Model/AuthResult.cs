﻿using System.Collections.Generic;

namespace Masterdetails_Core_Api.Model
{
    public class AuthResult
    {
        public string Token { get; set; }
        public bool Result { get; set; }
        public List<string> Errors { get; set; }
    }
}
