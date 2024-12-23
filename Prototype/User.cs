﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    public abstract class User : ICloneable
    {
        public string FirstName {  get; set; }
        public string LastName { get; set; }
        public string UserName {  get; set; }
        public string Password { get; set; }
        public Address HomeAddress { get; set; }
        public Address BusinessAddress { get; set; }
        
        public abstract object Clone();
        public abstract User DeepClone();
    }
}
