﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace NumSharp
{
    public partial class NumPyRandom
    {
        public void shuffle(NDArray list)
        {
            var count = list.size;

            Array listArr = list.Array;

            while (count > 1)
            {
                count--;
                var k = randomizer.Next(count + 1);
                var value = listArr.GetValue(k);
                listArr.SetValue(listArr.GetValue(count),k); 
                listArr.SetValue(value,count);
            }
        }
    }
}
