using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;


namespace Knapsack
{
    class DyProg
    {
        DataSet inputdata;
        int[,] dictionary;

        public DyProg(DataSet inputdata)
        { 
            this.inputdata = inputdata;
            dictionary = new int[inputdata.capacity + 1,inputdata.items + 1];
        }

        public Solution Solveit(DataSet inputdata)
        {
            // Dynamic Programming Algo
            // create a dictionary of items vs value
            // populate the dicitionary one by one

            for (int i = 1; i <= inputdata.items; i++)
            {
                for (int j = 1; j <= inputdata.capacity; j++)
                {
                    // is there capacity to fill the sack?
                    //if (inputdata.weights[i] <= j)
                    //{

                        // if I have i=1 to i=i items, what is the best solution?
                        // 
                        int curr_val = 0;

                        if (j - inputdata.weights[i] >= 0)
                          curr_val = dictionary[j - inputdata.weights[i], i -1] + inputdata.values[i];
                                                
                        if (curr_val > dictionary[j, i - 1])
                        {
                            dictionary[j, i] = curr_val;
                        }
                        else
                        {
                            dictionary[j, i] = dictionary[j, i - 1];
                        }
                        
                    //}
                    //else
                    //{
                    //    dictionary[j, i] = 0;
                    //}
                }
            }

            // traverse dictionary for solution by passing it to the Solution object
            return new Solution(dictionary, inputdata);
        
        }

    }
}
