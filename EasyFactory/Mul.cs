﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EasyFactory
{
    public class Mul:Operation
    {
        public override double GetRestult()
        {
            //throw new NotImplementedException();
            return this.Numberone * this.Numbertwo;
        }
    }
}
