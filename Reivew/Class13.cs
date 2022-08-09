/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiple
{
    interface IC
    {
        void myMethod();
    }

    interface ICM
    {
        void myOtherMethod();
    }


    class DemoClass : IC, ICM
    {
        public void myMethod()
        {
            Console.WriteLine("This is my method");
        }

        public void myOtherMethod()
        {
            Console.WriteLine("This is first");
        }
    }
    public class Program
    {
        public static void Main(string[] args)
        {
            DemoClass myObj = new DemoClass();
            myObj.myMethod();
            myObj.myOtherMethod();
        }

    }
}*/