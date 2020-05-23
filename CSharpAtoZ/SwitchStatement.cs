using System;

namespace CSharpAtoZ
{
    class SwitchStatement
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Result is : " + ResultProcessor());

        }

        static string ResultProcessor()
        {
            Console.Write("Enter 1st number : ");
            double n1 = Convert.ToDouble( Console.ReadLine());

            Console.Write("Enter Operator : ");
            char op = Convert.ToChar( Console.ReadLine());

            Console.Write("Enter 2nd number : ");
            double n2 = Convert.ToDouble(Console.ReadLine());

            string rs = "";
            double result = 0;

            switch (op)
            {
                case '+':
                    result = Add(n1, n2);
                    rs = Convert.ToString(result);
                    break;
                case '-':
                    result = Sub(n1, n2);
                    rs = Convert.ToString(result);
                    break;
                case '*':
                    result = Mul(n1, n2);
                    rs = Convert.ToString(result);
                    break;
                case '/':
                    result = Div(n1, n2);
                    rs = Convert.ToString(result);
                    break;
                default:
                    rs ="Invalid Operator";
                    break;

            }

            return rs;

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


//Enter 1st number : 6
//Enter Operator : *
//Enter 2nd number : 6
//Result is : 36





