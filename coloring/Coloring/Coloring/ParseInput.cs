using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.IO;

namespace Knapsack
{
    class ParseInput
    {
        public static DataSet ParseIt(string[] args)
        {
            
           string fileName = null;
        
        // get the temp file name
        foreach(string arg in args) 
                {
                    if(arg.StartsWith("-file=")){
                        fileName = arg.Substring(6);
                } 
            }


        if(fileName == null)
            throw new IndexOutOfRangeException();
        
        // read the lines out of the file
        
         List<string> lines = 
             File.ReadAllLines(
             (Directory.GetCurrentDirectory() + "\\" + fileName)
             )
             .ToList();

             
        // parse the data in the file
        string[] firstLine = lines[0].Split(' ');
        int items = Int32.Parse(firstLine[0]);
        int capacity = Int32.Parse(firstLine[1]);

        int[] values = new int[items + 1];
        int[] weights = new int[items + 1];

        for(int i=1; i < items+1; i++){
          String line = lines[i];
          String[] parts = line.Split(' ');

          values[i] = Int32.Parse(parts[0]);
          weights[i] = Int32.Parse(parts[1]);
        }


        return new DataSet(weights, values, items, capacity); 
    }
        
    }
}
