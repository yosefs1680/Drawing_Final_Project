using Contracts.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace DrawnigContracts.DTO
{
    public class LoginResponseOk : ResponseOk<string>
    {
        public LoginResponseOk(string msg) : base(msg) { }
    }
}
