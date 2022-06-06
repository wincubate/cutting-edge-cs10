using System;

namespace Wincubate.CS7x.Slide08
{
    struct Equipment
    {
        public string Console { get; set; }
        public int Controllers { get; set; }
        public bool IsVREnabled { get; set; }
    }

    class Program
    {
        static void Main( string[] args )
        {
            Equipment e = new Equipment
            {
                Console = "PlayStation 5",
                Controllers = 2,
                IsVREnabled = true
            };

            var tuple = (e.Console, e.Controllers);

            // Console.WriteLine(tuple.Console);
        }
    }
}