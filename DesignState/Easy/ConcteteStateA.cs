﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignState.Easy
{
    public class ConcteteStateA:State
    {

        public override void Handler(Context context)
        {
            //throw new NotImplementedException();
            context.Sate = new ConcteteStateB();
        }
    }
}
