using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step113Method
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Class1 instantiate = new Class1();
            //call the method in the class, passing in two numbers
            instantiate.MethodA(7, 11);

            //call the method in the class, specifying the parameters by name
            instantiate.MethodA(x: 7, y: 11);

        }
    }
}
