using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Knapsack
{
    class TrivialSolver
    {
        public Solution Solveit(DataSet inputdata)
        {

            // a trivial greedy algorithm for filling the knapsack
            // it takes items in-order until the knapsack is full
            int value = 0;
            int weight = 0;
            int[] taken = new int[inputdata.items];

            for (int i = 0; i < inputdata.items; i++)
            {
                if (weight + inputdata.weights[i] <= inputdata.capacity)
                {
                    taken[i] = 1;
                    value += inputdata.values[i];
                    weight += inputdata.weights[i];
                }
                else
                {
                    taken[i] = 0;
                }
            }

            return new Solution(taken, value);
        
        }

    }
}
