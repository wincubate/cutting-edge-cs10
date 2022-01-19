using System;
using System.Collections.Generic;
using System.Linq;

namespace Wincubate.CS9.KeyToAwesomenessLab
{
    class Program
    {
        static void Main( string[] args )
        {
            var served = new Dictionary<CoffeeKey, int>();

            void Serve( string customerName, CoffeeKind kind, CoffeeSize size, int strength )
            {
                Console.WriteLine($"Serving a {size} {kind} of strength {strength} to {customerName}");

                var key = new CoffeeKey(kind, size, strength);

                if (served.ContainsKey(key) == false)
                {
                    served[key] = 1;
                }
                else
                {
                    served[key]++;
                }
            }

            void PrintSummary() => served
                .OrderByDescending(kv => kv.Value)
                .ThenBy(kv => kv.Key.Kind)
                .ThenByDescending(kv => kv.Key.Size)
                .ThenByDescending(kv => kv.Key.Strength)
                .Select(kv => $"Served {kv.Value} {kv.Key.Size} {kv.Key.Kind} of strength {kv.Key.Strength}")
                .ToList()
                .ForEach(Console.WriteLine)
                ;

            RandomHelper helper = new();

            for (int i = 0; i < 100; i++)
            {
                CoffeeKind kind = helper.GetRandomCoffeeKind();
                CoffeeSize size = helper.GetRandomCoffeeSize();
                int strength = helper.GetRandomCoffeeStrength();

                Serve(helper.GetRandomName(), kind, size, strength);
            }

            Console.WriteLine();
            PrintSummary();
        }
    }
}