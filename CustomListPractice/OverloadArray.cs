using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomListPractice
{
    class OverloadArray
    {
        public string x1 = "";
        public string x2 = "";
        public double y1 = 0;
        public List<string> name;
        public List<int> age;
        
        public OverloadArray(string x1, double y1)
        {
            this.x1 = x1;
            this.y1 = y1;
        }

        public OverloadArray(List<string> name, List<int> age)
        {
            this.name = name;
            this.age = age;
        }

        public static OverloadArray operator +(OverloadArray x, OverloadArray y)
        {
            OverloadArray xy = new OverloadArray(x.x1 + y.x1, x.y1 + y.y1);
            return xy;
        }
        public void display()
        {
            Console.WriteLine(x1);
            Console.WriteLine(y1);
        }
        public static OverloadArray operator -(OverloadArray x, OverloadArray y)
        {
            OverloadArray xy = new OverloadArray(x.x1, x.y1 - y.y1);
            return xy;
        }
    }
}
