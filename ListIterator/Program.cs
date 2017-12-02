using System;
using System.Collections.Generic;

namespace BookIterator
{
    class Program
    {
        static void Main(string[] args)
        {
            MyAggregate aggr = new MyAggregate();

            aggr[0] = "3";
            aggr[1] = "5";
            aggr[2] = "8";
            aggr[3] = "9";
            aggr[4] = "13";
            aggr[5] = "34";
            aggr[6] = "56";
            aggr[7] = "45";
            aggr[8] = "67";
            aggr[9] = "15";

            IIterator iter = aggr.GetIterator();

            for (string s = iter.FirstItem; iter.IsDone == false; s = iter.NextItem)
            {
                Console.Write(s+" ");
            }

            Console.Write("\nElements quantities in colection: " + aggr.Count);

            Console.ReadKey();
        }
    }
}
