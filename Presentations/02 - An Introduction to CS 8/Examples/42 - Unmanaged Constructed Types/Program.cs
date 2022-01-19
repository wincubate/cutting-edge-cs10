using System;

namespace Wincubate.CS8.Slide42
{
    public struct Position<T>
    {
        public T X;
        public T Y;
    }

    unsafe struct Unsafe
    {
        public fixed int FixedField[10];
    }

    class Program
    {
        unsafe static void HandleUnmanaged<T>(T t) where T : unmanaged
        {
            T* p = &t;
            // ...
        }

        static void Main(string[] args)
        {
            HandleUnmanaged(new Position<int>());
            HandleUnmanaged(new Unsafe());
        }
    }
}
