using NLog;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiThreadNlogDemo
{
    public class ABank
    {
       
        readonly object _myLock = new object();
        int _processCount;

        ConcurrentDictionary<int, int> keyValuePairs = new ConcurrentDictionary<int, int>();
        NLog.Logger _logger;
        public ABank(int processCount)
        {
            _logger = NLog.LogManager.GetLogger("test");
            // Trace - Warn levelları arasında FileManager2'yi kullanacak.
            _logger.Log(LogLevel.Info, "Create");

            this._processCount = processCount;
            for (int i = 0; i < _processCount; i++)
            {
                keyValuePairs.TryAdd(i, i * i);
            }
        }


        public void WriteToText()
        {
            lock (_myLock)
            {
                for (int i = 0; i < keyValuePairs.Count; i++)
                {
                    // Nlog write
                    int value;
                    Console.WriteLine(keyValuePairs.TryGetValue(i, out value));
                    Console.WriteLine(value);
                 
                    _logger.Debug($"Value[{i}]= { value}");

                }
            }
        }
    }


}
