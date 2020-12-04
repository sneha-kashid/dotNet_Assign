using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceInterface

{
    class Program
    {
        static void Main(string[] args)
        {

            //Employee e = new Employee();


            Employee e1 = new Manager("T", 2, "manager");
            e1.Basic = 2500;
            e1.Display();
            Console.WriteLine();

            Employee e2 = new GeneralManager("neha", 3, "GeneralManager", "xyz");
            e2.Basic = 30000;
            e2.Display();
            Console.WriteLine();

            Employee e3 = new CEO("sweety", 4);
            e3.Basic = 10000000;
            e3.Display();
            Console.WriteLine();


            Employee e4 = new Manager();

            e4.Display();
            Console.WriteLine();

            Employee e5 = new GeneralManager();

            e5.Display();
            Console.WriteLine();


            Employee e6 = new CEO();

            e6.Display();
            Console.WriteLine();


            Console.ReadLine();
        }
    }

    public interface IDbFunctions
    {
        void Insert();
        void Delete();
        void Update();
    }
    abstract class Employee:IDbFunctions
    {
        //constructor
        public Employee()
        { }

        //name property
        private string name;
        public string Name
        {
            get { return name; }
            set
            {
                if (value == "default")
                {
                    name = "Employee";
                }
                else
                {
                    name = value;
                }
            }
        }

        //empNo property
        private int empNo;
        private static int S_empno = 0;
        public int EmpNo
        {
            get { return empNo; }
            private set { empNo = ++S_empno; }
        }

        //dept_no property
        private short deptNo;
        public short DeptNo
        {
            get { return deptNo; }
            set
            {
                if (value == 0)
                {
                    deptNo = 1;
                }

                deptNo = value;
            }
        }

        //basic property
        protected decimal basic;
        public abstract decimal Basic { set; get; }

        public Employee(string name = "default", short depNo = 0)
        {
            EmpNo = 23;
            this.Name = name;
            this.DeptNo = depNo;
        }


        public abstract decimal CalcNetSalary();

        public virtual void Display()
        {
            Console.Write(EmpNo + " " + Name + " " + DeptNo + " " + basic + " " + CalcNetSalary() + " ");
        }

        public void Insert()
        {
            Console.WriteLine("Employee - Insert");
        }

        public void Delete()
        {
            Console.WriteLine("Employee - Delete");

        }

        public void Update()
        {
            Console.WriteLine("Employee - Update");

        }
    }



    class Manager : Employee,IDbFunctions
    {
        private string designation;


        public string Designation
        {
            get { return designation; }
            set
            {
                if (value == "default")
                {
                    designation = "employee";
                }
                designation = value;
            }
        }

        public Manager(string name = "default", short depNo = 0, string designation = "default") : base(name, depNo)
        {
            this.Designation = designation;
        }
        public override decimal Basic
        {
            get
            {
                return basic;
            }

            set
            {
                if (value <= 15000)
                {
                    basic = 15000;
                }

                basic = value;
            }
        }

        public override decimal CalcNetSalary()
        {
            return Basic * 1000;
        }


        public override void Display()
        {
            base.Display();
            Console.Write(designation);
        }
    }

    class GeneralManager : Manager,IDbFunctions
    {
        private string perks;
        public string Perks
        {
            get { return perks; }
            set { perks = value; }
        }
        public GeneralManager(string name = "default", short depNo = 0, string designation = "default", string perks = "default") : base(name, depNo, designation)
        {
            this.Perks = perks;
        }

        public override void Display()
        {
            base.Display();
            Console.Write(" " + Perks);
        }

    }

    class CEO : Employee,IDbFunctions
    {
        public override decimal Basic
        {
            get { return basic; }
            set
            {
                if (value <= 5000)
                {
                    basic = 5000;
                }
                basic = value;
            }
        }

        public CEO(string name = "default", short deptNo = 0) : base(name, deptNo)
        {

        }
        public sealed override decimal CalcNetSalary()
        {
            return Basic * 1000 * 20;
        }
    }

    class jack : Employee,IDbFunctions
    {
        public override decimal Basic { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public override decimal CalcNetSalary()
        {
            Console.WriteLine("jack Sealed Method");
            return 3;
        }
    }


}





