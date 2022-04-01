using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace EMPLOYEE_WAGES
    {
        class Employee
        {
            static void Main(string[] args)
            {
                int isPresent = 1;
                Random random = new Random();
                int Empinput = random.Next(0, 2);
                if (isPresent == Empinput)
                    Console.WriteLine("EMPLOYEE IS PRESENT");
                else
                    Console.WriteLine("EMPLOYEE IS ABSENT");
            }
        }
    }


