using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Coloring
{
    class TrivialSolver
    {
        internal Solution Solveit(DataSet inputData)
        {
            // A new color to every node
            int[] colors = Enumerable.Range(0, inputData.node_count).ToArray();

            return new Solution(colors, inputData.node_count);
        }
    }
}
