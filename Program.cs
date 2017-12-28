using System;

namespace SimpleSteemSocket
{
    class Program
    {
        private static SimpleSteemSocket sss;
        
        static void Main(string[] args)
        {
            sss = new SimpleSteemSocket();
            Console.WriteLine("Anzahl der Konten/Number of accounts:");
            Console.WriteLine(sss.FormatJSON(sss.Transaction("get_account_count")));
        }
    }
}
