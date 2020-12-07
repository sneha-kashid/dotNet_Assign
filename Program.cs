using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoDArray
{
    class Program
    {
        static void Main1()
        {
            int[,] arr = new int[5, 3];
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write("Enter marks for student number {0} and subject {1} : " , i, j);
                  
                    arr[i, j] = Convert.ToInt32(Console.ReadLine());

                }
            }
            Console.WriteLine();

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.WriteLine("Marks for student number {0} and subject {1} : {2}", i, j,arr[i,j]);
                   

                }
            }
        }

        static void Main2()
        {
            Console.WriteLine("Enter Number of student");
            int Stud = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the marks");
            int Marks = Convert.ToInt32(Console.ReadLine());
            int[,] arrS = new int[Stud, Marks];

            for (int i = 0; i < Stud; i++)
            {
                for (int j = 0; j < Marks; j++)
                {
                    Console.Write("Enter marks for student number {0} and subject {1} : ", i, j);

                    arrS[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.WriteLine();

            for (int i = 0; i < Stud; i++)
            {
                for (int j = 0; j < Marks; j++)
                {
                    Console.WriteLine("Marks for student number {0} and subject {1} : {2}", i, j, arrS[i, j]);


                }
            }
        }

        static void Main()
        {
            //Console.WriteLine("Enter Number of student");
            //int Stud = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Enter the marks");
            //int Marks = Convert.ToInt32(Console.ReadLine());
            int[,] arrS = new int[5, 2];

            Console.WriteLine(arrS.Rank);
            Console.WriteLine(arrS.Length);
            Console.WriteLine(arrS.GetLowerBound(0));
            Console.WriteLine(arrS.GetLowerBound(1));
            Console.WriteLine(arrS.GetUpperBound(0));
            Console.WriteLine(arrS.GetUpperBound(1));


            for (int i = 0; i < arrS.GetLength(0) ; i++)
            {
                for (int j = 0; j <arrS.GetLength(1); j++)
                {
                    Console.Write("Enter marks for student number {0} and subject {1} : ", i, j);

                    arrS[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.WriteLine();

            for (int i = 0; i < arrS.GetLength(0); i++)
            {
                for (int j = 0; j < arrS.GetLength(1); j++)
                {
                    Console.WriteLine("Marks for student number {0} and subject {1} : {2}", i, j, arrS[i, j]);


                }
            }
        }

    }
}
