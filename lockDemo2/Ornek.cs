using System;
using System.Collections.Generic;
using System.Threading;

namespace lockDemo2
{
    public class Ornek
    {

        private readonly object _kilit = new object();

        readonly List<int> _genericList = new List<int>();

        private readonly int _basilacakDegerSayisi = 0;

        public Ornek(int baslanilacakDegerSayisi)
        {
            _basilacakDegerSayisi = baslanilacakDegerSayisi;
        }

        public void VerileriBas()
        {
            lock (_kilit)
            {
                for (var i = 0; i < _basilacakDegerSayisi; i++)
                {
                    _genericList.Add(i);
                    Thread.Sleep(1000);
                    Console.WriteLine(i+ "ekledi");
                }
                Console.WriteLine("Döngü Tamamlandı!");
            }
        }

        public void VeriSil(int silinecekVerininIndexNumarasi)
        {
            //kullanıcı eğer silinecek numarayı girerse ve eğer
            //_kilit isimli LOCK işlem için dondurulmuşsa burada beklemeye
            //alınacaktır. Diğer işlem bitimine kadar Lock içindeki kodlar çalışmayacaktır.
            lock (_kilit)
            {
                Console.WriteLine("VeriSil Metodu Çalıştı.");
                _genericList.RemoveAt(silinecekVerininIndexNumarasi);
                Console.WriteLine($"Liste {_genericList.Count}");
            }
           
        }

        public void BastanSil()
        {
           
            lock (_kilit)
            {
                while (_genericList.Count > 0)
                {

                    _genericList.RemoveAt(0);

                    Console.WriteLine("Silme sonrası");
                    foreach (var item in _genericList)
                    {
                        Console.WriteLine(item);
                    }
                    Console.WriteLine("-------------------");
                    Thread.Sleep(1000);

                }
            }
        }
        public void Katla()
        {
            lock (_kilit)
            {
                for (int i = 0; i < _genericList.Count; i++)
                {
                    _genericList[i] = _genericList[i] * _genericList[i];
                    Thread.Sleep(1000);
                }
            }
        }
    }
}