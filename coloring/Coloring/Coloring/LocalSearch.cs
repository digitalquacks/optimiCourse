using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Coloring
{
    class LocalSearch
    {
        private DataSet inputData;
        private Solution bestSol;

        public LocalSearch(DataSet inputData, Solution greedySol)
        {
            // TODO: Complete member initialization
            this.inputData = inputData;
            this.bestSol = greedySol;
        }

        internal Solution Solveit()
        {
            //throw new NotImplementedException();

            int[] da;
            int prev_score = evaluate_initial_Solution(bestSol, out da);
            // replace the kth color with k-1 color

            int min_pos = 0;
            foreach (int d in da)
                if (d != da.Min())
                {
                    min_pos++;
                }
                else
                    break;
            
            
            
            for (int intr = 0; intr < bestSol.num_colors -1; intr++)
            {
                int[] colors = new int[bestSol.assigned.Length];
                bestSol.assigned.CopyTo(colors, 0);

                List<int> colors_used = new List<int>(bestSol.used_colors);
                
                colors_used.Sort();
                
                
                int last_color = colors_used.ElementAt(colors_used.Count - 1);
                int prev_color = colors_used.ElementAt(colors_used.Count - 2);

                int[] color_cluster_size = new int[colors_used.Count];
                int[] number_bad_edges = new int[colors_used.Count];

                for (int i = 0; i < colors.Length; i++)
                {
                    if (colors[i] == last_color)
                    {
                        colors[i] = prev_color;
                        int[] neibhors = inputData.edges[i];
                        
                        foreach(int neibhor in neibhors)
                            if (colors[i] == colors[neibhor])
                            {
                                number_bad_edges[colors[i]]++;
                            }
                    }

                    color_cluster_size[colors[i]]++;

                }

                colors_used.RemoveAt(colors_used.Count - 1);

                int curr_score = evaluate_score(number_bad_edges, color_cluster_size, colors_used.Count);

                if (curr_score < prev_score)
                {
                    bestSol = new Solution(colors, colors_used);
                    prev_score = curr_score;
                }
                

                // compute score
                // if prv_score > score
                // replace this solution
            
            }

            return bestSol;
        }

        internal int evaluate_score(int[] num_bad_edges, int[] color_cluster_size, int num_colors)
        { 
            int score = 0;
            for (int i = 0; i < num_colors; i++)
            {
                score += (2 * num_bad_edges[i] * color_cluster_size[i]) - (color_cluster_size[i] * color_cluster_size[i]); 
            }

            return score;
        
        }

        internal int evaluate_initial_Solution(Solution sol, out int[] color_cluster_size)
        {
            int[] colors = sol.assigned;
            List<int> colors_used = bestSol.used_colors;
            colors_used.Sort();


            color_cluster_size = new int[colors_used.Count];
            int[] number_bad_edges = new int[colors_used.Count];

            for (int i = 0; i < colors.Length; i++)
            {  
                    int[] neibhors = inputData.edges[i];

                    foreach (int neibhor in neibhors)
                        if (colors[i] == colors[neibhor])
                        {
                            number_bad_edges[colors[i]]++;
                        }
                
                color_cluster_size[colors[i]]++;

            }

           return evaluate_score(number_bad_edges, color_cluster_size, colors_used.Count);
       
        }
    }
}
