
        
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
                int EMP_WAGE_PER_HR = 20, EMP_HR = 8, empwage = 0;
                Random random = new Random();
                int Empinput = random.Next(0, 2);
            if (isPresent == Empinput)
            {
                Console.WriteLine("EMPLOYEE IS PRESENT");
                EMP_HR = 8;
            }
            else
            {
                Console.WriteLine("EMPLOYEE IS ABSENT");
                EMP_HR = 0;
            }
                empwage = EMP_HR * EMP_WAGE_PER_HR;
                Console.WriteLine("EMPLOYEE WAGE :" + empwage);
                Console.ReadLine();

            }
        }
    }




