using System;

namespace ConsoleApp4
{
    internal class Class1
    {
        static void Main()
        {
            Customer c = new Customer(100, "chandra", true, 100000,Cities.Hyderabad,"Karnataka","India");
            Console.WriteLine("customer is : " + c.Cid);
            c.Cid = 20;
            Console.WriteLine("customer is : " + c.Cid);
            Console.WriteLine(c.Status);
            c.Status = true;
            c.Balance -= 3000;
            Console.WriteLine(c.Balance);
            Console.WriteLine(c.City);
            c.City = Cities.Delhi;
            Console.WriteLine(c.State);
            //c.State = "Telangana";
            Console.WriteLine("Modified:" + c.City);
            Console.WriteLine(c.Country);
            Console.ReadLine();
        }
    }
}
