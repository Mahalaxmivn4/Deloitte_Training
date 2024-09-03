using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int eid;
            string ename;
            string ejob;
            int salary;

            Console.WriteLine("enter your emplyee id:");
            eid = int.Parse(Console.ReadLine());

            Console.WriteLine("enter your ename:");
            ename = Console.ReadLine();

            Console.WriteLine("enter your ejob:");
            ejob = Console.ReadLine();

            Console.WriteLine("enter your emplyee salary:");
            salary = int.Parse(Console.ReadLine());

            Console.WriteLine("_____user details________");
            Console.WriteLine("employee id:" + eid);
            Console.WriteLine("employee name:" + ename);
            Console.WriteLine("employee job:" + ejob);
            Console.WriteLine("employee salary:" + salary);
            Console.ReadLine();


        }
    }
}

