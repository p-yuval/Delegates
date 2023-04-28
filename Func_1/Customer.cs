namespace Func_1
{
    internal class Customer
    {
        private int age;

        public Customer(int id, string name)
        {
            ID = id;
            Name = name;
        }

        public Customer(string name, int age)
        {
            Name = name;
            this.Age = age;
        }

        public int ID
        {
            get;
            private set;
        }
        public string Name
        {
            get;
            private set;
        }
        public int Age
        {
            get => age;
            set => age = value;
        }
    }
}
