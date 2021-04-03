using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{

    class ProgramA
    {
        //test
        public int MyProperty;

        public void Print(int x)
        {
            Console.Write(x);
        }
    }

    class ProgramB
    {
        public int MyProperty;

        public void Print(int x)
        {
            Console.Write(x);
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            ProgramA obj_a = new ProgramA();
            ProgramB obj_b = new ProgramB();
            obj_a.MyProperty = 0;
            obj_a.Print(2);
            obj_b.MyProperty = 0;
            obj_b.Print(3);
            Console.Write(obj_a.MyProperty+ obj_b.MyProperty);
            var asm = Assembly.LoadFile(@"C:\Users\shukl\Downloads\Compressed\icuuc36.dll");
        }
    }
}
