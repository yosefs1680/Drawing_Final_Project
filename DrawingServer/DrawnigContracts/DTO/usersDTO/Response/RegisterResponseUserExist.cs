using Contracts.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace DrawnigContracts.DTO
{
    public class RegisterResponseUserExist: ResponseError<string>
    {
        public RegisterResponseUserExist(string msg) : base(msg) { }
    }
}
