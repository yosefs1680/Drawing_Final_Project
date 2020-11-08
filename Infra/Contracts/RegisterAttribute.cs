﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Contracts
{
    public enum Policy { Singleton, Scoped, Transient }
    public class RegisterAttribute : Attribute
    {
        public RegisterAttribute(Policy policy, Type interfaceType)
        {
            Policy = policy;
            InterfaceType = interfaceType;
        }
        public Policy Policy { get; private set; }
        public Type InterfaceType { get; private set; }
    }
}
