using System;

namespace test
{
    class Program
    {
       

        public static void Main()
        {
            Console.WriteLine("里程：");        
            Ticket t = new Ticket(Convert.ToDouble(Console.ReadLine()));
            t.ShowTicket();
            
        }

        
    }
}
