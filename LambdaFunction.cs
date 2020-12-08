using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaFunc

{
    class Program
    {
        static void Main()
        {

            //1. decimal SimpleInterest(decimal P, decimal N, decimal R) -> returns calculated SimpleInterest
            Func<decimal, decimal, decimal, decimal> obj = (P, R, N) => P * R * N / 100;
            Console.WriteLine(obj(10000, 2, (decimal)3.4));


            //2. bool IsGreater(int a, int b) -> returns true if a is > b
            Func<int,int,bool> obj1 = (a, b) => a > b;
            Console.WriteLine(obj1(5,2));

            // 3. decimal GetBasic(Employee e) -> returns the Basic salary of the employee
            Func<decimal, decimal> obj2 = (s) => s;
            Console.WriteLine(obj2(200));

            //4. bool IsEven(int num) -> returns true if the number is an even number
            Predicate<int> obj3 = (a) => a % 2 == 0;
            Console.WriteLine(obj3(2));

            //5. bool IsGreaterThan10000(Employee e) -> returns true if the Basic Salary is > 10000
            Predicate<decimal> obj4 = (b) => b > 10000;
            Console.WriteLine(obj4(1000000));


        }
    }
}
