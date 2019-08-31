using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nlogdemo2
{
    class Program
    {
        static void Main(string[] args)
        {
            var logger = NLog.LogManager.GetLogger("test");
            // Trace - Warn levelları arasında FileManager2'yi kullanacak.
            logger.Log(LogLevel.Info, "Sample Info error message");
            logger.Log(LogLevel.Debug, "Sample Debug");
            logger.Log(LogLevel.Warn, "Sample Warn");
            logger.Log(LogLevel.Trace, "Sample Trace");
            //Error ve yukarısı için FileManager'ı kullanacak.
            logger.Log(LogLevel.Error, new Exception("Hata1"));
            logger.Log(LogLevel.Error, new Exception("Hata2"));




            Console.ReadLine();
        }
    }
}
