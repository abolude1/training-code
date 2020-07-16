using System;

namespace Calculator
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Welcome to our Basic Calculator");
            var stay = true;
            
            do
            {
            Console.WriteLine("Menu");
            Console.WriteLine("Press 1 for Addition");
            Console.WriteLine("Press 2 for Substraction");
            Console.WriteLine("Press 3 for Multiplication");
            Console.WriteLine("Press 4 for Division");
            Console.WriteLine("Press 5 for Exit");

            var choice = Console.ReadLine();

            switch(choice)
            {
                case "1":
                //  var input1 = (double)Console.ReadLine(); //explicit casting with exception
                //  var input2 = Console.ReadLine() as double; //explicit casting with null
                  
                var input1 = double.Parse(Console.ReadLine()); //explicit parsing with 0
                double input2;
                double.TryParse(Console.ReadLine(), out input2); //explicit parsing with boolean exception     
                
                Add(input1, input2);
                break;

              case "2":
               double input3;
               double input4;

               if(double.TryParse(Console.ReadLine(), out input3))
               {
                    System.Console.WriteLine("valid");
               } 
               else
               {
                   System.Console.WriteLine("not valid");
               }

                if(double.TryParse(Console.ReadLine(), out input4))
               {
                    System.Console.WriteLine("valid");
               } 
               else
               {
                   System.Console.WriteLine("not valid");
               }

               Subtract(input3, input4);
              break;
               
             case "3":
                var input5 = double.Parse(Console.ReadLine()); //explicit parsing with 0
                double input6;
                double.TryParse(Console.ReadLine(), out input6); //explicit parsing with boolean exception     
                
                Multiply(input5, input6);
                break;

             case "4":
               double input7;
               double input8;

               if(double.TryParse(Console.ReadLine(), out input7))
               {
                    System.Console.WriteLine("valid");
               } 
               else
               {
                   System.Console.WriteLine("not valid");
               }

                if(double.TryParse(Console.ReadLine(), out input8))
               {
                    System.Console.WriteLine("valid");
               } 
               else
               {
                   System.Console.WriteLine("not valid");
               }

               Divide(input7, input8);
              break;

              case "default":
                stay = false;
                break;
            }
        } 
        while (stay);
        
        static void Add(double operand1, double operand2)
        {
            var result = operand1 + operand2;
            System.Console.WriteLine($"your answer is: {result}");
        }

        static void Subtract(double operand3, double operand4)
        {
            var result = operand3 - operand4;
            System.Console.WriteLine($"your answer is: {result}");
        }
        static void Multiply(double operand5, double operand6)
        {
            var result = operand5 * operand6;
            System.Console.WriteLine($"your answer is: {result}");
        }
        static void Divide(double operand7, double operand8)
        {
            var result = operand7 / operand8;
            System.Console.WriteLine($"your answer is: {result}");

            System.Console.ReadLine();
           }
      }
    }
}
