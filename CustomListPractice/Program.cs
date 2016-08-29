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
            GenericList<int> genericList1 = new GenericList<int>();
            Console.WriteLine("adding an object");
            genericList1.AddArray(12);
            genericList1.AddArray(213);
            genericList1.AddArray(99);
            genericList1.AddArray(6687);
            genericList1.AddArray(213);
            genericList1.Print();
            Console.ReadLine();
            Console.WriteLine("subtracting an object");
            genericList1.RemoveArray2(213);
            genericList1.Print();
            Console.ReadLine();
            Console.WriteLine("List to String");
            string toString = genericList1.ListToString().ToString();
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
            GenericList<int> genericList2 = new GenericList<int>();
            genericList2.AddArray(1);
            genericList2.AddArray(1);
            genericList2.AddArray(1);
            genericList2.AddArray(1);
            genericList2.AddArray(1);
            genericList2.AddArray(1);
            GenericList<int> genericList3 = new GenericList<int>();
            genericList3.AddArray(5);
            genericList3.AddArray(5);
            genericList3.AddArray(5);
            genericList3.AddArray(5);
            genericList3.AddArray(5);
            GenericList<int> result = new GenericList<int>();
            Console.WriteLine("add list operator overload");
            result = genericList2 + genericList3;
            result.Print();
            Console.ReadLine();
            Console.WriteLine("Zipper");
            genericList2.Zipper(genericInt);
            genericList2.Print();
            Console.ReadLine();
            Console.WriteLine("subtract list operator overload");
            result = result - genericList3;
            result.Print();
            Console.ReadLine();
            Console.WriteLine("Sorting number from low to high(starting from bottom)");
            genericList1.SortArray();
            genericList1.Print();
            Console.ReadLine();
            genericList1.HappyNumber();
            genericList1.Print();
            Console.ReadLine();
        }
    }
}
