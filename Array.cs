using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee e = new Employee(1, "sneha", 6000);
            Employee e1 = new Employee(2, "neha", 7000);
            Employee e3 = new Employee();
            // Employee e2 = new Employee(3, null ,320);
            // Console.WriteLine("sneha");
            //  Console.WriteLine(e.EmpNo);
            // Console.WriteLine(e.Name);
            //Console.ReadLine();

            

            Employee[] arrE = { e, e1};
            decimal maxSal = arrE[0].Salary;
            Console.WriteLine("Enter EmpNo");
            int empN = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < arrE.Length; i++)
            {
                if (maxSal < arrE[i].Salary)
                    maxSal = arrE[i].Salary;



                Console.WriteLine(arrE[i].EmpNo + " " + arrE[i].Name + " " + arrE[i].Salary);


            }

            Console.WriteLine("Maximum salary : {0}", maxSal);

            for (int i = 0; i < arrE.Length; i++)
            {
         

                if (arrE[i].EmpNo == empN)
                {
                    Console.WriteLine("mere details");
                    Console.WriteLine(arrE[i].EmpNo + " " + arrE[i].Name + " " + arrE[i].Salary);
                }



            }
          

            
            //Console.WriteLine("Enter ");            


           


            Console.ReadLine();


            Console.WriteLine();
        }

    }

    public class Employee
    {
        int empNo;
        string name;
        decimal salary;

        public int EmpNo
        {
            set
            {
               // if (empNo != null)
                    empNo = value;
              //else
               //Console.WriteLine("invalid");

            }

            get
            {
                return empNo;
            }
        }

        public string Name
        {
            set
            {
               //if (name != null)
                    name = value;
                //else
                  //  Console.WriteLine("invalid");

            }

            get
            {
                return name;
            }
        }

        public decimal Salary
        {
            set
            {
                //if (salary != 0)
                    salary = value;
                //else
                  // Console.WriteLine("invalid");

            }

            get
            {
                return salary;
            }
        }

        public Employee(int empNo, string name, decimal salary)
        {
            this.EmpNo = empNo;
            this.Name = name;
            this.Salary = salary;
        }

        public Employee()
        {
            this.EmpNo = empNo;
            this.Name = name;
            this.Salary = salary;
        }
    }
}
