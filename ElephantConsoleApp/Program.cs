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
            // add 4 to swap two variables directly but it is dangerous
            Console.WriteLine("Press 1 for Lloyd, 2 for Lucinda, 3 to swap, 4 is dangerous");
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
                // add choice 4 to swap two reference variable directly
                else if (choice == 4)
                {
                    Console.WriteLine("You pressed 4");

                    // after this statement, both the lloyd and lucinda variables 
                    // reference the SAME Elephant object. So the Elephant object
                    // that lloyd used to point to has gone...poof!!
                    lloyd = lucinda;

                    // set EarSize to 4321 on whatever object the reference stored
                    // in the lloyd variable happens to point to, which is the object
                    // that lucinda points to. The important thing is that these two
                    // variables can change the same object's data.
                    lloyd.EarSize = 4321;

                    lloyd.WhoAmI();
                }
                else
                {
                    Console.WriteLine("Please enter an integer among 1, 2, 3, 4");                    
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
