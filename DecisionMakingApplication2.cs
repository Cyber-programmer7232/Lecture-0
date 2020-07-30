using System; 
namespace Csharp
{
    class DecisionMaking
    { 
        static void Main(string[] args) 
        {
            char grade = 'B'; 
            switch (grade) 
            {
                case 'A':
                    {
                        Console.WriteLine("Excellent!");
                    
                    }
                    break; 
                case 'B':
                    {
                        Console.WriteLine("Well done");
                    }
                    break;
                case 'C': 
                    {
                        Console.WriteLine("You passed");
                    }
                    break;
                case 'D':
                    {
                        Console.WriteLine("Better try again"); 
                    }
                    break;
                case 'F':
                    {
                        Console.WriteLine("You Failed!!!!"); 
                    }
                    break;
                default:
                Console.WriteLine("Your grade is  {0}", grade);
                Console.ReadLine();
            }   
        } 
    } 
} 
