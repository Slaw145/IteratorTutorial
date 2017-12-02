using System;

namespace IterateChannels
{
    class Program
    {
        static void Main(string[] args)
        {
            TunedChannel aggr = new TunedChannel();

            aggr[0] = "Channel 1";
            aggr[1] = "Channel 2";
            aggr[2] = "TVN";
            aggr[3] = "PLUS";
            aggr[4] = "POLSAT";
            
            IIterator iter = aggr.GetChannelIterator();
            string s = iter.FirstChannel;
            string ToShiftChannel = null;

            Console.WriteLine("We are starting from "+s);

            while (!string.IsNullOrEmpty(ToShiftChannel = Console.ReadLine()) && iter.IsDone == false)
            {
                if (ToShiftChannel == "Next")
                {
                    s = iter.Next;
                    Console.WriteLine(s);
                }
                else if(ToShiftChannel == "Previous")
                {
                    s = iter.Previous;
                    Console.WriteLine(s);
                }
            }

            Console.ReadKey();
        }
    }
}
