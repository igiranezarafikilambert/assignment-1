using System;

namespace Lambert
{
    class Prog
    {

        static void Main(string[] args)
        {


            double a;
            double b;
            string choice;
            var operation1 = new Calculate();
            Console.WriteLine("Enter the value of a");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the value of b");
            b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("enter operator");
            choice= console.ReadLine();
            
            if(operator=="+")
            console.WriteLine("sum= {0}",operation1.Add(a,b));

            if(operator=="-")
            console.WriteLine("subtraction= {0}",operation1.subtract(a,b));

            if(operator=="*")
            console.WriteLine("multiplication= {0}",operation1.Multiply(a,b));

            if(operator=="/")
            console.WriteLine("division= {0}",operation1.Divide(a,b));

            else
            {
                console.WriteLine("wrong operator");
            }

        
         
        
        }
    }

}        