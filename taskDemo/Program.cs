using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace taskDemo
{
    class Program
    {
        static async Task Main(string[] args)
        {
            white();
            _ = red();
            _ = yellow();
            _ = black();

            Console.ReadKey();
        }

        public static async Task red()
        {
            await Task.Run(() =>
            {
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine("red");
                    Thread.Sleep(500);
                }
                Console.WriteLine("red ------------------ end");
            });
        }


        public static async Task yellow()
        {
            await Task.Run(() =>
            {

                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine("yellow");
                    Thread.Sleep(500);
                }
                Console.WriteLine("yellow ----------------end");
            });

        }





        public static void white()
        {
            for (int i = 0; i < 10; i++)
            {
                Thread.Sleep(500);
                Console.WriteLine($"{i} white");
            }
            Console.WriteLine("white --------------end");
        }

        public static async Task black()
        {
            await Task.Run(() =>
            {
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine("black");
                    Thread.Sleep(500);
                }
                Console.WriteLine("black-------------end");
            });
        }
    }
}