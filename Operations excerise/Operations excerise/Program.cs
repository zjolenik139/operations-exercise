using System;

namespace Operations_excerise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(Add(5,4));
            //Console.WriteLine(Sub(3,2));
            //Console.WriteLine(Multiply(5,10));
            //Console.WriteLine(Divide(8,4));
            //Console.WriteLine(Modulus(4,2));
            //Console.WriteLine("Hello World!");
            
            
            int a = 17;
            int b = 4;
            int quotient = a / b;
            int remainder = a % b;
            if (a == 17 && b == 4)

            
           // Console.WriteLine($"{a} divided by {b} is {quotient} remainder {remainder}");

            Console.WriteLine("Please enter the radius of your circle:");
            var userInput = Console.ReadLine();
            var radius = double.Parse(userInput);
            Console.WriteLine(Methods.AreaOfCircle(radius));
           
        }

         
        
        
        
        
        
        
      




    }
}
