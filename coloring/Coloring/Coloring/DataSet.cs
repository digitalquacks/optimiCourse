using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Coloring
{
    class DataSet
    {
        private int[,] edges;
        public int node_count;
        private int edge_count;

        public DataSet(int[,] edges, int node_count, int edge_count)
        {
            // TODO: Complete member initialization
            this.edges = edges;
            this.node_count = node_count;
            this.edge_count = edge_count;
        }
        

    }
}
