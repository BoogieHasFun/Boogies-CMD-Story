using System; 

namespace A_Program
{
    class Program
    {
        static void Main(string[] agrs)    
        {
            Console.WriteLine("Hello, the man with the sword.. What is your name?");
            Console.ReadLine();
            Console.WriteLine("Great Name! What do you like most: Games or Coding?");
            Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("Nice!");
            Console.ForegroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.White;
            Console.WriteLine("You can edit this all you want on https://github.com/BoogieHasHun/Boogies-CMD-Story!");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\r   ");
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("Click any key to exit.");
            
            Console.ReadKey();
        }
    }  
}