using System;
using System.Collections.Generic;

namespace Labb_5___Generic_class
{
    public class Check<T> 
    {
  

        public void ToCheck(T data1, T data2)
        {
            if (data1.Equals(data2))
            {
                Console.WriteLine("De två variablerna är lika");
            }
            else
            {
                Console.WriteLine("De två variablerna är olika");
            }
        }
    }
    public class Child1 : Check<int>
    {

    }
    public class Child2 : Check<string>
    {

    }
    class Program
    {
        static void Main(string[] args)
        {
            Child1 Test1 = new Child1();
            Test1.ToCheck(10, 10);
            Console.WriteLine("----------------------------");

            Child1 Test2 = new Child1();
            Test2.ToCheck(10, 20);
            Console.WriteLine("----------------------------");

            Child2 TestString1 = new Child2();
            TestString1.ToCheck("Anas", "Tobias");
            Console.WriteLine("----------------------------");

            Child2 TestString2 = new Child2();
            TestString2.ToCheck("Daniel", "Daniel");
            Console.WriteLine("----------------------------");



        }
    }
}
