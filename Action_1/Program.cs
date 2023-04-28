namespace ActionsNS

{
    class Program
    {
        public System.Action<int, int> myAction;
        private int args1;

        public Program()
        {
            myAction = this.Add;


        }

        private void Add(int arg1, int arg2)
        {

            System.Console.WriteLine(arg1 + arg2);

        }

        public static void Main(string[] args)
        {

            Program program = new Program();
            program.myAction(4, 5);


        }
    }
}

