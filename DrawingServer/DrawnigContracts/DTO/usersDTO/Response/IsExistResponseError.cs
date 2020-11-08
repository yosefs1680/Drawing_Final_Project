using System;
using System.Collections.Generic;
using System.Text;

namespace DrawnigContracts.DTO
{
    public class IsExistResponseError : ResponseError<bool>
    {
        public IsExistResponseError(bool flag) : base(flag)
        {

        }
    }
}
