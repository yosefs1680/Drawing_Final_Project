using System;
using System.Collections.Generic;
using System.Text;

namespace DrawnigContracts.DTO
{
    public class IsExistResponseOk : ResponseOk<bool>
    {
        public IsExistResponseOk(bool response) : base(response) { }
    }
}
