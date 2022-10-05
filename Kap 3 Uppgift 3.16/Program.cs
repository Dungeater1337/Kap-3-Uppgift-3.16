using System; 

namespace Kapitel3_uppguft3_16
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("hur länge vill du spela låten"); 
            int svar = int.Parse (Console.ReadLine());

            if (svar >= 240 && svar <= 420)
            {
                Console.WriteLine(" du får spela låten");
            }

            else 
            {
                Console.WriteLine(" Du får inte spela låten"); 

            }
            
        }
    }
}