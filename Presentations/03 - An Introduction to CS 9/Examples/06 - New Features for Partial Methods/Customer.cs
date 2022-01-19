using System;

namespace Wincubate.CS9.D
{
    partial class Customer
    {
        private partial bool OnNameChanging(string newName)
        {
            Console.WriteLine($"Changing \"{_name}\" to \"{newName}\"");

            return _name != newName;
        }

        public partial void OnNameChanged(out string oldName)
        {
            oldName = _name;
            Console.WriteLine($"Changed to \"{_name}\"");
        }
    }
}
