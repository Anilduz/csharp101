using System;

namespace Arayuz_Kavrami
{
    public class DatabaseLogger : ILogger
    {
        public void WriteLog()
        {
            //throw new NotImplementedException();
            Console.WriteLine("logları db'ye yazar");
        }
    }
}