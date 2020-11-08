using Contracts.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace DrawnigContracts.DTO
{
    public class LoginResponseMailNotExist : ResponseError<string>
    {
        public LoginResponseMailNotExist(string msg) : base(msg) { }
    }
}
