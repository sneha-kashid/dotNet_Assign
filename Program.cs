using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class Program
    {
        static void Main()
        {
            //Employee e = new Employee();
            //e.Basic=30;
            //Console.WriteLine(e.Basic);
            //e.Name="neha";
            //Console.WriteLine(e.Name);
            //e.DeptNo = 1;
            //Console.WriteLine(e.DeptNo);
            //Employee.EmpNo=0;
            //Console.WriteLine(Employee.EmpNo);
            //Console.WriteLine(Employee.EmpNo);

           // Console.WriteLine(e.GetNetSalary());



            Employee o1 = new Employee("Amol", 34, 10);

            // Console.WriteLine(o1.EmpNo+" " +o1.DeptNo+" "+o1.Basic );
            //Console.WriteLine(o1.GetNetSalary());
            Console.WriteLine(o1.EmpNo);
            Employee o2 = new Employee("Amol", 46);
            Console.WriteLine(o2.EmpNo);
            Employee o3 = new Employee("Amol");
            Console.WriteLine(o3.EmpNo);
            Employee o4 = new Employee();
            Console.WriteLine(o4.EmpNo);
            // o3.EmpNo--;

            // Employee o3 = new Employee("Amol");
            Console.WriteLine(o4.EmpNo);
            Console.WriteLine(o3.EmpNo);
            Console.WriteLine(o2.EmpNo);
            Console.WriteLine(o1.EmpNo);

        }
    }

    class Employee
    {

        public Employee()
        {
            emp_no=++var;
        }

        public Employee(string Name)
        {
            this.Name = Name;
            emp_no=++var;
        }

        public Employee(string Name,int Basic)
        {
            emp_no=++var;
            this.Name = Name;
            this.Basic = Basic;
        }
        public Employee(string Name, int Basic, short DeptNo)
        {
            emp_no=++var;
            this.Name = Name;
            this.Basic = Basic;
            this.DeptNo = DeptNo;
            
        }
        private string name;
        public string Name
        {
            set
            {
                if(value != null)
                    name = value;
                else
                    Console.WriteLine("name can't be null");
            }
            get
            {
                return name;
            }
        }

        private  int emp_no;
        private static int var;
        public  int EmpNo
        {
           
            get
            {
             
                return emp_no;
            }
            

        }

        private int basic;
        public int Basic
        {
            set
            {
                if (value > 20 && value < 50)
                    basic = value;
                else
                    Console.WriteLine("invalid");
            }
            get
            {
                return basic;
            }
        }

        private short dept_no;
        public short DeptNo
        {
            set
            {
                if (value > 0)
                    dept_no = value;
                else
                    Console.WriteLine("invalid");
            }
            get
            {
                return dept_no;
            }
        }


        public float GetNetSalary()
        {
            float sal = Basic + 4000 + 1000;
            return sal;
        }



    }
}
