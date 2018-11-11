using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenrateAndDivide
{
    class Program
    {
        //The Program generates two random numbers than divides a higher number by a lower number
        
        static void Main(string[] args)
        {
            var randomNumber = new RandomFinder();
            decimal firstRandomNo = randomNumber.GetPseudoRandom();
            decimal secRandomNo = randomNumber.GetPseudoRandom();
            
            decimal result;

            if (firstRandomNo > secRandomNo)
            {
                result= firstRandomNo / secRandomNo;
            }
            else
            {
                result = secRandomNo / firstRandomNo;
            }
            Console.WriteLine("First random number: {0}", firstRandomNo);
            Console.WriteLine("Second random number: {0}", secRandomNo);
            Console.WriteLine(result);
            Console.ReadKey();
        }     
    }
}
