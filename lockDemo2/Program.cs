using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace lockDemo2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Adet:");
            int adet = int.Parse(Console.ReadLine());

            var ornek = new Ornek(adet);

            var threadEkle = new Thread(ornek.VerileriBas);

            threadEkle.Start();


            var threadSil = new Thread(ornek.BastanSil);

            threadSil.Start();



            var threadKatla = new Thread(ornek.Katla);

            threadKatla.Start();
        }
    }
}
