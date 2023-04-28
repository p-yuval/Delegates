using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate_6
{
    delegate void Transformer(int x);

    public static class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            int num = int.Parse(Console.ReadLine() ?? string.Empty);
            Transformer t = Square;
            t += Cube;
            t.Invoke(num);

            NotifyMethods notify = new NotifyMethods();
            notify.TransformerEvent += User1.Xhandler;

            //if we use transformerEvent as a delegate , we can use the equal sign
            //thus overriding all previous assignments.
            //To overcome this obstacle we can use the event, which enforces us to use
            //the +=  or -=  so that we can only add or remove a subscriber. 
            notify.TransformerEvent += User2.Yhandler;
            notify.NotifyOnCall(num);

            Console.ReadLine();
        }


        static void Square(int i)
        {
            Console.WriteLine(i * i);
        }

        static void Cube(int i)
        {
            Console.WriteLine(i * i * i);
        }
    }

    class NotifyMethods
    {
        public event Transformer? TransformerEvent;

        public void NotifyOnCall(int i)
        {
            if (TransformerEvent != null)
            {
                TransformerEvent(i);
            }
        }
    }

    class User1
    {
        public static void Xhandler(int x)
        {
            Console.WriteLine(x + " = Event received by User 1 object");
        }
    }

    class User2
    {
        public static void Yhandler(int x)
        {
            Console.WriteLine(x + " = Event received by User 2 object ");
        }
    }
}