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
                args = new string[] { "-file=/data/ks_400_0" };


            DataSet inputData = ParseInput.ParseIt(args);

         //   inputData = fix_Data(inputData);

            DyProg dp = new DyProg(inputData);
            DisplayOutput(dp.Solveit(inputData), inputData);

            //TrivialSolver ts = new TrivialSolver();
            //DisplayOutput(ts.Solveit(inputData), inputData);

        }

        private static DataSet fix_Data(DataSet inputData)
        {
            int diff =  inputData.weights.Max() - inputData.weights.Min();

            for (int i = 0; i < inputData.weights.Length; i++)
                inputData.weights[i] = (inputData.weights[i] - inputData.weights.Min()) / (diff);

            inputData.capacity = (inputData.capacity - inputData.weights.Min()) / (diff);

            return inputData;
        }


        static void DisplayOutput(Solution outputdata, DataSet inputData)
        {
        // Console.WriteLine();
        // prepare the solution in the specified output format
        Console.Out.WriteLine(outputdata.value +" 0");
        for(int i=0; i < inputData.items; i++){
            Console.Out.Write(outputdata.taken[i] + " ");
        }
        Console.Out.WriteLine("");       

        }

    }
}
