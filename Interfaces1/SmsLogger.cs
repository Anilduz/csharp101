using System;

namespace Arayuz_Kavrami{
    public class SmsLogger : ILogger
    {
        public void WriteLog()
        {
            //throw new NotImplementedException();
            Console.WriteLine("SMS olarak log yazar");
        }
    }
}