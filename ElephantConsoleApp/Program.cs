namespace ElephantConsoleApp;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        Elephant lloyd = new Elephant() { EarSize = 40, Name = "Lloyd" };
        Elephant lucinda = new Elephant() { EarSize = 33, Name = "Lucinda" };
        
        while (true)
        {
            Console.WriteLine("Press 1 for Lloyd, 2 for Lucinda, 3 to swap");
            string? line = Console.ReadLine();
            if (int.TryParse(line, out int choice))
            {
                if (choice == 1)
                {
                    Console.WriteLine("You pressed 1");
                    Console.WriteLine("Calling lloyd.WhoAmI()");
                    lloyd.WhoAmI();                   
                }
                else if (choice == 2)
                {
                    Console.WriteLine("You pressed 2");
                    Console.WriteLine("Calling lucinda.WhoAmI()");
                    lucinda.WhoAmI();               
                }
                else if (choice == 3)
                {
                    Console.WriteLine("You pressed 3");
                    Console.WriteLine("References have been swapped");
                    Elephant temp = lloyd;
                    lloyd = lucinda;
                    lucinda = temp;                
                }
                else
                {
                    Console.WriteLine("Please enter an integer among 1, 2, 3");                    
                }
            }
            else
            {
                Console.WriteLine("unvalid numbers");
                return;
            }

            Console.WriteLine();
        }
       
    }
}
