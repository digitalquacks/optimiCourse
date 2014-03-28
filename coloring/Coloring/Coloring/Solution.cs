using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Coloring
{
    class Solution
    {
        public int num_colors  = 0;
        public int[] assigned;

        public Solution(int[] assigned, int num_colors)
        {
            // TODO: Complete member initialization
            this.assigned = assigned;
            this.num_colors = num_colors;
        }

    }
}
