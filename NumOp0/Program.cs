using System;

namespace NumOp0
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1, num2;
            Console.WriteLine("Enter an operator");
            Console.WriteLine("+  -  *  /");
            string op = Console.ReadLine();
            switch(op)
            {
                case "+":
                    Console.WriteLine("Addition entered..");
                    break;

                case "-":
                    Console.WriteLine("Substraction entered..");
                    break;

                case "*":
                    Console.WriteLine("Multiplication entered..");
                    break;

                case "/":
                    Console.WriteLine("Division entered..");
                    break;
                default:
                    Console.WriteLine("Invalid..");
                    break;

            }
            Console.WriteLine("Enter two numbers");
            Console.WriteLine("Number 1:");
            num1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Number 2:");
            num2 = double.Parse(Console.ReadLine());
            
            Program p = new Program();

            p.basicOp(op,num1,num2);
        }
        public void basicOp(string op, double num1, double num2)
        {
            switch (op)
            {
                case "+":
                    Console.WriteLine("Sum: "+(num1 + num2));
                    break;

                case "-":
                    Console.WriteLine("Difference: " +(num1 - num2));
                    break;

                case "*":
                    Console.WriteLine("Product: " + Math.Round((num1 * num2),3));
                    break;

                case "/":
                    Console.WriteLine("Quotient: "+Math.Round((num1 / num2),3));
                    break;
                default:
                    Console.WriteLine("Invalid");
                    break;

            }
        }

    }
}
