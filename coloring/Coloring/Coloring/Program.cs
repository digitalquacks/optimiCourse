using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Coloring
{
    class Program
    {
        static void Main(string[] args)
        {
          if (args.Length == 0)
           //  args = new string[] { "-file=/data/gc_4_1" };
            args = new string[] { "-file=/data/gc_1000_5" };


            DataSet inputData = ParseInput.ParseIt(args);

            TrivialSolver ts = new TrivialSolver();
            LocalSearch dp = new LocalSearch(inputData, ts.Solveit_Greedy(inputData));
            DisplayOutput(dp.Solveit(), inputData);

             //TrivialSolver ts = new TrivialSolver();
             //DisplayOutput(ts.Solveit(inputData), inputData);

            //TrivialSolver ts = new TrivialSolver();
            //DisplayOutput(ts.Solveit_Greedy(inputData), inputData);

        }

        static void DisplayOutput(Solution outputdata, DataSet inputData)
        {
            // Console.WriteLine();
            // prepare the solution in the specified output format
            Console.Out.WriteLine(outputdata.num_colors + " 0");
            for (int i = 0; i < inputData.node_count; i++)
            {
                Console.Out.Write(outputdata.assigned[i] + " ");
            }
           
            Console.WriteLine();
        }
    }
}
