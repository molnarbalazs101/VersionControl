﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tasks_week08.Abstractions;

namespace tasks_week08.Entities
{
    public class BallFactory : Abstractions.IToyFactory
    {
        public Toy CreateNew()
        {
            return new Ball();
        }
    }
}
