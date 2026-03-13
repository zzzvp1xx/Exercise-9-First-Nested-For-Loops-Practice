namespace Exercise_9_First_Nested_For_Loops_Practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Get the width of how many stars across
            Console.Write("Enter a number for how many stars should appear across: ");
            int width = int.Parse(Console.ReadLine());

            //get the height of how many rows down
            Console.Write("Enter how many rows of stars you want to appear down: ");
            int height = int.Parse(Console.ReadLine());

            //nested for loop
            for (int i = 1; i <= height; i++)
            {

                for (int j = 1; j <= width; j++)
                {
                    Console.Write("*"); //star needs to be inside inner loop bc this runs first??
                }
                Console.WriteLine();
            }

            //Ask the user for the max size
            Console.WriteLine(); 
            Console.Write("Type a max number of stars in a row: ");
                int starRow = int.Parse(Console.ReadLine());

            // (OuterLoop) Counts which row we are on
            Console.WriteLine();
                for (int i = 1; i <= starRow; i++) 
                {

               // (InnerLoop) Prints stars for the current row when it hits the current row number (i)
                 for (int j = 1; j <= i; j++) 
                 {
                    Console.Write("*");
                }
                 Console.WriteLine();
            }        
        }
    }
}
  
