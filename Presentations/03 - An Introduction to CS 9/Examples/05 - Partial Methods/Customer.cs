using System;

namespace Wincubate.CS9.D
{
    partial class Customer
    {
        partial void OnNameChanging(string newName)
        {
            Console.WriteLine($"Changing \"{_name}\" to \"{newName}\"");
        }

        partial void OnNameChanged()
        {
            Console.WriteLine($"Changed to \"{_name}\"");
        }
    }
}
