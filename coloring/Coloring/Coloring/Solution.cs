using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Knapsack
{
    class Solution
    {
        public int[] taken;
        public double value;
       
        public Solution(int[] taken, int value)
        {
            this.taken = taken;
            this.value = value;
        }

        public Solution(int[,] dictionary, DataSet inputdata)
        {
            // TODO: Complete member initialization

            taken = new int[inputdata.items];
            value = 0;
            int consider = inputdata.capacity;

            for (int i = inputdata.items; i > 0; i--)
            {
                if (dictionary[consider, i] != dictionary[consider, i -1])
                {
                    taken[i -1] = 1;
                    consider -= inputdata.weights[i];
                }
                else
                    taken[i -1] = 0;
            }

            value = dictionary[inputdata.capacity, inputdata.items];
        
        }

    }
}
