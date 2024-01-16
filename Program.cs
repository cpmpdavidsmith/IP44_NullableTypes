using System;

namespace Nullable
{
    class Program
    {
        static void Main()
        {
            int? x = null;
            int? y = 11;
            if (x== null)
            {
                Console.WriteLine(y.Value);
            }
            else
            {
                Console.WriteLine("Undefined");
            }
            Console.Read();
        }
    }
}
