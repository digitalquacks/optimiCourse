using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Coloring
{
    class TrivialSolver
    {
        private int newcolor =0;
        internal Solution Solveit(DataSet inputData)
        {
            // A new color to every node
            int[] colors = Enumerable.Range(0, inputData.node_count).ToArray();
            return new Solution(colors, inputData.node_count);
        }

        internal Solution Solveit_Greedy(DataSet inputData)
        {
            // A new color to every node
            int[] colors = new int[inputData.node_count];
            List<int> used_colors = new List<int>();
            Boolean[] coloured = new bool[inputData.node_count];

            coloured[0] = true;
            colors[0] = newcolor;
            used_colors.Add(newcolor);
                        
            //foreach(int node in inputData.edges.Keys) 
            for(int node = 1; node < inputData.node_count; node++)
   
                {
                    int[] neibhors = inputData.edges[node];
                    List<int> unavilable = new List<int>();
                    
                foreach (int neibhor in neibhors)
                    {
                        if (coloured[neibhor])
                        {
                            unavilable.Add(colors[neibhor]);
                        }
                    }

                    //unavilable.Sort();

                List<int> available_color = used_colors.Except(unavilable).ToList();

                   if (available_color.Count != 0)
                   {
                       available_color.Sort();
                       colors[node] = available_color[0];
                       coloured[node] = true;
                   }
                   else
                   {
                       colors[node] = ++newcolor;
                       used_colors.Add(newcolor);
                       coloured[node] = true;
                   }

                }


            return new Solution(colors, used_colors);
              //return new Solution(colors, ++newcolor);
        }


    }
}
