using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.IO;

namespace Coloring
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
        int node_count = Int32.Parse(firstLine[0]);
        int edge_count = Int32.Parse(firstLine[1]);

        //int[,] edges = new int[edge_count,2];

        Dictionary<int, int[]> edges = new Dictionary<int, int[]>();
        
        for(int i=1; i <= edge_count; i++){
          String line = lines[i];
          String[] parts = line.Split(' ');

          //edges[i,0] = Int32.Parse(parts[0]);
          //edges[i,1] = Int32.Parse(parts[1]);

          int left = Int32.Parse(parts[0]);
          int right = Int32.Parse(parts[1]);

              if (edges.ContainsKey(left))
              {
                  var arr = edges[left].ToList<int>();
                  arr.Add(right);
                  edges[left] = arr.ToArray();
              }
              else
              {
                  var arr = new List<int>();
                  arr.Add(right);
                  edges[left] = arr.ToArray();
              }

            // since it is undirected graph

              if (edges.ContainsKey(right))
              {
                  var arr = edges[right].ToList<int>();
                  arr.Add(left);
                  edges[right] = arr.ToArray();
              }
              else
              {
                  var arr = new List<int>();
                  arr.Add(left);
                  edges[right] = arr.ToArray();
              }

        }

        return new DataSet(edges, node_count, edge_count); 
    }
        
    }
}
