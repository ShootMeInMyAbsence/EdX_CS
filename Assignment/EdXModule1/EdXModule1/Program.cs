using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EdXModule1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Student Information
            string sFirstName, sLastName, sAddressLine1, sAddressLine2, sCity, sState, sZip, sCountry;
            DateTime dDOB;
            sFirstName = "Bhoy";
            sLastName = "Northshore";
            sAddressLine1 = "1234 Normanby Road";
            sAddressLine2 = "Mount Eden";
            sCity = "Auckland";
            sState = "Auckland";
            sZip = "1022";
            sCountry = "New Zealand";
            dDOB = new DateTime(1979,10,31);
            // Input
            Console.WriteLine("First name:      ");
            sFirstName = Console.ReadLine();
            Console.WriteLine("Last name:       ");
            sLastName = Console.ReadLine();
            Console.WriteLine("Address line 1:  ");
            sAddressLine1 = Console.ReadLine();
            Console.WriteLine("Address line 2:  ");
            sAddressLine2 = Console.ReadLine();
            Console.WriteLine("City:            ");
            sCity = Console.ReadLine();
            Console.WriteLine("State:           ");
            sState = Console.ReadLine();
            Console.WriteLine("Post code:       ");
            sZip = Console.ReadLine();
            Console.WriteLine("Country:         ");
            sCountry = Console.ReadLine();
            Console.WriteLine("DOB dd/mm/yyyy:  ");
            dDOB = DateTime.Parse(Console.ReadLine());
            // Output
            Console.WriteLine("First name: {0}", sFirstName);
            Console.WriteLine("Last name:  {0}", sLastName);
            Console.WriteLine("Address:    {0}", sAddressLine1);
            Console.WriteLine("            {0}", sAddressLine2);
            Console.WriteLine("City:       {0}", sCity);
            Console.WriteLine("State:      {0}", sState);
            Console.WriteLine("Post code:  {0}", sZip);
            Console.WriteLine("Country:    {0}", sCountry);
            Console.WriteLine("DOB:        {0:dd/MM/yy}", dDOB);
            Console.WriteLine("Press any key to stop...");
            Console.ReadKey();

        }
    }
}
