using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Coloring
{
    class DataSet
    {
        public int[,] edges_list;
        public int node_count;
        public int edge_count;
        public Dictionary<int, int[]> edges;
        
        public DataSet(int[,] edges, int node_count, int edge_count)
        {
            // TODO: Complete member initialization
            this.edges_list = edges;
            this.node_count = node_count;
            this.edge_count = edge_count;
        }

        public DataSet(Dictionary<int, int[]> edges, int node_count, int edge_count)
        {
            // TODO: Complete member initialization
            this.edges = edges;
            this.node_count = node_count;
            this.edge_count = edge_count;
        }
        

    }
}
