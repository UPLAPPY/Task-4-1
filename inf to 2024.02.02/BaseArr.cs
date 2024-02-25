﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inf_to_2024._02._02
{
    abstract class BaseArr: IBaseArr
    {
        public virtual void Average()
        {

        }

        public virtual void Create(bool avto_input = false)
        {
            if (avto_input)
            {
                AvtoInput();
            }
            else
            {
                ArrayInput();
            }
        }

        public abstract void AvtoInput();

        public abstract void ArrayInput();

        public virtual void PrintArray()
        {

        }
    }
}
