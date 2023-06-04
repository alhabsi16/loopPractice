namespace loop1
{
    internal class Program
    {
        static void Main(string[] args)
        { 

            /*   
               
               *****
               *   *
               *   *
               *   *
               *****
               
            */
             
               
            
            // ptint the first line
            int i = 0;
            while (i<5)
            {
                Console.Write("*");
                i++;
            }
            Console.WriteLine();

            int j = 0;
            while (j<3)
            {
                Console.Write("*   *");
                j++;
                Console.WriteLine();
            }
            int k = 0;
            while (k < 5)
            {
                Console.Write("*");
                k++;
            }
        }
    }
}