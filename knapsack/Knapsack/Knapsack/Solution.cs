using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Knapsack
{
    class Solution
    {
        public int[] taken;
        public int value;

        public Solution(int[] taken, int value)
        {
            this.taken = taken;
            this.value = value;
        }
    }
}
