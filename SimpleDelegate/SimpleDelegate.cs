using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SimpleDelegate
{
    //Delegate is more like a type. A class;
    public delegate void StringDelegate(string str);


    public class MainClassd
    {
        public static void Main()
        {
            SimpleDelegate obj = new SimpleDelegate();

        }

    }

    public class SimpleDelegate
    {

        public SimpleDelegate()
        {
            StringDelegate lower = ToLowerCase;
            StringDelegate upper = ToUpper;

            lower("HELLO");
            upper("hello");
        }


        public void ToUpper(string str) => Console.WriteLine(str.ToUpper());
        public void ToLowerCase(string str) => Console.WriteLine(str.ToLower());
        // another commit
    }

}




