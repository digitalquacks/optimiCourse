using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Knapsack
{
    class DataSet
    {
        public int[] weights, values;
        public int items, capacity;


        public DataSet(int[] weights, int[] values, int items, int capacity)
        {
            this.weights = weights;
            this.values = values;
            this.items = items;
            this.capacity = capacity;
        }

    }
}
