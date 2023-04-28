using System.ComponentModel;

namespace Func_1
{
    public class CustomerViewModel : IDataErrorInfo
    {
        private Customer _customer;


        private static readonly char[] IllegalCharacters = new char[] { '_', '!', '@', '%' };


        public string Name
        {
            get; set;
        }

        public int Age
        {
            get; set;
        }

        public string Error
        {
            get
            {
                throw new NotImplementedException();
            }
        }



        public string this[string columnName]
        {
            get
            {
                string error = string.Empty;

                switch (columnName)
                {
                    case "Name":
                    if (Name.IndexOfAny(IllegalCharacters) > 0)
                    {
                        error = string.Format(
                            "The customer's name contains illegal characters({0})",
                            new string(IllegalCharacters));
                    }
                    break;
                    case "Age":
                    if (Age < 21)
                    {
                        error = "Customers must be 21 or over to shop here!";
                    }
                    break;
                }

                return error;
            }
        }

        public void CreateCustomer()
        {
            _customer = new Customer(Name, Age);
        }
    }


}
