namespace Func_1
{
    internal class Program
    {
        public Func<int, int, int>? sum;

        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Program program = new Program();
            program.sum = AddTwoNumbers;
            Console.WriteLine(program?.sum(5, 8));
        }

        private static int AddTwoNumbers(int arg1, int arg2)
        {
            return arg1 + arg2;
        }
    }
}