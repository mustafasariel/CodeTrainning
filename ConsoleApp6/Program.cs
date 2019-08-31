﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                var sonuc = GetPersonInfo(i );
                if (sonuc != null)
                {
                    Console.WriteLine($"{ sonuc.Item1},{ sonuc.Item2},{sonuc.Item3}");
                }
          
            }

        }

        public static Tuple<string, string, int> GetPersonInfo(int personId)
        {
            switch (personId)
            {
                case 1:
                    return new Tuple<string, string, int>("Seniha", "Özgür", 1976);
                case 2:
                    return new Tuple<string, string, int>("Ali", "Özgür", 1975);
                case 3:
                    return new Tuple<string, string, int>("Arda", "Özgür", 2006);
                default:
                    return null;
            }
        }
    }
}
