using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace NumberGusser
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            while (true)
            {
                Console.WriteLine("You wish to continue press 1.To start 2.Quit");
                int chooseOption = Convert.ToInt32(Console.ReadLine());

                if (chooseOption == 1)
                {
                    function1();
                }
                else
                {
                    break;
                }
               
            }
            
                    
             
        }
        static void function1()
        {
            Random random = new Random();
            int radomNumber = random.Next(1, 11);
            //Console.WriteLine("" + radomNumber); used to see random number
            int counter = 0;
            while (true)
            {

                counter++;
                Console.WriteLine("Enter the Guss Number between 1 to 10");
                int choosenNumber = Convert.ToInt32(Console.ReadLine());

                if (choosenNumber < radomNumber)
                {
                    Console.WriteLine("Sorry,You are Too Low ");
                }
                else if (choosenNumber > radomNumber)
                {
                    Console.WriteLine("Sorry,You are Too High ");
                }
                else if (choosenNumber == radomNumber)
                {
                    Console.WriteLine("You win ");

                    Console.WriteLine("You Attemted " + counter);
                    break;
                    


                }
            }
            
        }
    }
}
