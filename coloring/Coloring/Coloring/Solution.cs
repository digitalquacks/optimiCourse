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
        public List<int> used_colors;

        public Solution(int[] assigned, int num_colors)
        {
            // TODO: Complete member initialization
            this.assigned = assigned;
            this.num_colors = num_colors;
        }

        public Solution(int[] colors, List<int> used_colors)
        {
            // TODO: Complete member initialization
            this.assigned = colors;
            this.used_colors = used_colors;
            this.num_colors = used_colors.Count;
        }

    }
}
