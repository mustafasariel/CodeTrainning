using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MultiThreadNlogDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Thread Count");
            int _threadCount = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Process Count");
            int _processCount = Convert.ToInt32(Console.ReadLine());

           
            
          


            for (int i = 0; i < _threadCount; i++)
            {
                ABank aBank = new ABank(_processCount);
                Thread thread = new Thread(aBank.WriteToText);
                thread.Start();
            }

            Console.ReadKey();

        }
    }
}
