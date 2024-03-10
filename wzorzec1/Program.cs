using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




namespace LogowanieKomunikatow
{
    public class Log
    {
        private static Log _instance;
        private List<string> logMessages;

        private Log()
        {
            logMessages = new List<string>();
        }

        public static Log GetInstance()
        {
            if (_instance == null)
            {
                _instance = new Log();
            }
            return _instance;
        }

        public void LogMessage(string message)
        {
            logMessages.Add(message);

        }

        public List<string> GetLogMessages()
        {
            return logMessages;
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Log log1 = Log.GetInstance();
            log1.LogMessage("komunikat logowania 1");
            Log log2 = Log.GetInstance();
            log2.LogMessage("komunikat logowania 2");

            Console.WriteLine("Komunikaty logowania z log1");
            foreach (var message in log1.GetLogMessages())
            {
                Console.WriteLine(message);
            }

            Console.WriteLine("Komunikaty logowania z log2");
            foreach (var message in log2.GetLogMessages())
            {
                Console.WriteLine(message);
            }

            Console.ReadKey();

        }
    }

}

