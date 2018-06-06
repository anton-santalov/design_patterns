using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Text;
// using System.Threading.Tasks;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            // First time authorization.
            AccountEntry.Lock();
            Console.ReadLine();
            // Second time authorization.
            AccountEntry.Lock();
            Console.ReadLine();
        }
    }

    class AccountEntry
    {
        // Authorization date.
        private static DateTime time;

        private static AccountEntry entry;

        private AccountEntry()
        {
            // Initialize authorization date.
            time = DateTime.Now;
        }

        // Entry creation.
        public static AccountEntry Lock()
        {
            if (entry == null)
            {
                entry = new AccountEntry();
                Console.WriteLine("Account entry created.");
                Console.WriteLine("Creation date: {0}", time);
            }
            else
            {
                Console.WriteLine("Error! \n" +
                    "Account entry has already been created.");
                Console.WriteLine("Время создания: {0}", time);
            }
            return entry;
        }
    }
}
