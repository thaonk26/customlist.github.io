using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomListPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> genericInt = new List<int> { 99, 99, 99, 99, 99 };
            GenericList<int> gen = new GenericList<int>();
            Console.WriteLine("adding an object");
            gen.AddArray(12);
            gen.AddArray(213);
            gen.AddArray(99);
            gen.AddArray(6687);
            gen.AddArray(213);
            gen.Print();
            Console.ReadLine();
            //Console.WriteLine("subtracting an object");
            //gen.RemoveArray2(213);
            //gen.Print();
            //Console.ReadLine();
            Console.WriteLine("List to String");
            string toString = gen.ListToString().ToString();
            Console.WriteLine(toString);
            Console.ReadLine();
            //Console.WriteLine("simple operator overload");
            //OverloadArray obj = new OverloadArray("hi", 55.5);
            //OverloadArray obj2 = new OverloadArray(" there", 45);
            //OverloadArray obj3 = obj + obj2;
            //OverloadArray obj4 = obj - obj2;
            //obj3.display();
            //obj4.display();
            //Console.ReadLine();
            //GenericList<int> gen3 = new GenericList<int>();
            //gen3.AddArray(1);
            //gen3.AddArray(1);
            //gen3.AddArray(1);
            //gen3.AddArray(1);
            //gen3.AddArray(1);
            //gen3.AddArray(1);
            //GenericList<int> gen4 = new GenericList<int>();
            //gen4.AddArray(5);
            //gen4.AddArray(5);
            //gen4.AddArray(5);
            //gen4.AddArray(5);
            //gen4.AddArray(5);
            //GenericList<int> result = new GenericList<int>();
            //Console.WriteLine("add list operator overload");
            //result = gen3 + gen4;
            //result.Print();
            //Console.ReadLine();
            //Console.WriteLine("Zipper");
            //gen3.Zipper(genericInt);
            //gen3.Print();
            //Console.ReadLine();
            //Console.WriteLine("subtract list operator overload");
            //result = result - gen4;
            //result.Print();
            //Console.ReadLine();
            //Console.WriteLine("Sorting number from low to high");
            //gen.SortArray();
            //gen.Print();
            //Console.ReadLine();


            gen.HappyNumber();
            gen.Print();
            Console.ReadLine();
        }
    }
}
