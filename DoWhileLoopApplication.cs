using System;
namespace Csharp
{
    class DoWhileLoopApplication
    {
        static void Main(string[] args)
        {
            int a = 10;
            do
            {
                Console.WriteLine("value of a: {0}", a); a = a + 1;
            } while (a < 20);
            Console.ReadLine();
        }
    }
}
