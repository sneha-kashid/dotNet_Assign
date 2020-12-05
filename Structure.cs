using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structure
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student(" sneha", 0,20);
            Console.WriteLine(s.NAME + " " + s.ROLLNO + " " +s.MARKS);
        }
    }
    
    public struct Student
    {
        string Name;
        int? RollNo;
        decimal? Marks;

        public string NAME
        {
            set
            {
                if (Name != "def")
                    Name = value;
                else
                    Console.WriteLine("Name cannot be empty");
            }
            get
            {
                return Name;
            }
        }

        public int ROLLNO
        {
            set
            {
                if (RollNo > 0)
                {
                    RollNo = value;
                }
              else
                    Console.WriteLine("Roll no cannot be empty");
            }
            get
            {
                return (int)RollNo;
            }

        }

        public decimal MARKS
        {
            set
            {
                if (Marks > 0)
                    Marks = value;
                else
                    Console.WriteLine("failed");

            }
            get
            {
                return (int)Marks;
            }
        }



        public Student(string Name="user",int RollNo=0,decimal Marks=0)
        {
            
            this.Name = Name;
            this.RollNo = RollNo;
            this.Marks = Marks;


        }

    }
}
