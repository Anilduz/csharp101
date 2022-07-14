using System;

namespace Arayuz_Kavrami{
    class Program{
        public static void Main(string[] args)
        {
            Console.Clear();
            FileLogger filelogger = new FileLogger();
            filelogger.WriteLog();

            DatabaseLogger dbloger = new DatabaseLogger();
            dbloger.WriteLog();

            SmsLogger smslogger = new SmsLogger();
            smslogger.WriteLog();

            LogManager logManager = new LogManager(new FileLogger());
            logManager.WriteLog();

        }
    }
}