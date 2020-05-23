using System;

namespace CSharpAtoZ
{
    class CalculatorWithIfElse
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ResultProcessor());

        }

        static double ResultProcessor()
        {
            Console.Write("Enter 1st number : ");
            double n1 = Convert.ToDouble( Console.ReadLine());

            Console.Write("Enter Operator : ");
            char op = Convert.ToChar( Console.ReadLine());

            Console.Write("Enter 2nd number : ");
            double n2 = Convert.ToDouble(Console.ReadLine());


            double result = 0;

            if(op == '+')
            {
                result = Add(n1, n2);
            }

            else if (op == '-')
            {
                result = Sub(n1, n2);
            }

            else if (op == '*')
            {
                result = Mul(n1, n2);
            }

            else if (op == '/')
            {
                result = Div(n1, n2);
            }

            else
            {
                Console.WriteLine("Invalid operator");
            }



            return result;

        }


        static double Add(double num1, double num2)
        {
            double result = num1 + num2;
            return result;
        }

        static double Sub(double num1, double num2)
        {
            double result = num1 - num2;
            return result;
        }

        static double Mul(double num1, double num2)
        {
            double result = num1 * num2;
            return result;
        }

        static double Div(double num1, double num2)
        {
            double result = num1 / num2;
            return result;
        }


    }
}





