using System;
namespace Csharp
{
    class ForLoopApplication
    {
        static void Main(string[] args)
        {
            for (int a = 10; a < 20; a = a + 1)
            {
                Console.WriteLine("value of a: {0}", a);
            }
            Console.ReadLine();
        }
    }
}