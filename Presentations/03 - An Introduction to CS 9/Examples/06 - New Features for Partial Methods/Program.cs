using System;
using Wincubate.CS9.D;

Customer customer = new Customer
{
    Name = "Bruce Campbell"
};
customer.Name = "Saul Goodman";
Console.WriteLine($"The customer name is: {customer.Name}");

namespace Wincubate.CS9.D
{
    partial class Customer
    {
        private string _name;

        public string Name
        {
            get { return _name; }
            set
            {
                if( OnNameChanging(value) )
                {
                    _name = value;
                    OnNameChanged(out var old);
                }
            }
        }

        private partial bool OnNameChanging(string newName);
        public partial void OnNameChanged(out string oldName);
    }
}
