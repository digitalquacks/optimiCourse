using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Knapsack
{
    class Program
    {
        static void Main(string[] args)
        {

            if (args.Length == 0)
                args = new string[] { "-file=/data/ks_4_0" };


            DataSet inputData = ParseInput.ParseIt(args);

            //DyProg dp = new DyProg(inputData);
            //dp.SolveIt();

            TrivialSolver ts = new TrivialSolver();
            DisplayOutput(ts.Solveit(inputData), inputData);

        }


        static void DisplayOutput(Solution outputdata, DataSet inputData)
        {
            Console.WriteLine();

        // prepare the solution in the specified output format
        Console.Out.WriteLine(outputdata.value +" 0");
        for(int i=0; i < inputData.items; i++){
            Console.Out.WriteLine(outputdata.taken[i] + " ");
        }
        Console.Out.WriteLine("");       

        }

    }
}
