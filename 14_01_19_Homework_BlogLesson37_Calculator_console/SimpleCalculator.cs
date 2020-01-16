using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_01_19_Homework_BlogLesson37_Calculator_console
{
    class SimpleCalculator
    {
        public int NumberGetter()
        {
            Console.WriteLine("Please enter number:");
            int num = 0;
            do
            {
                if (!Int32.TryParse(Console.ReadLine(), out num)) Console.WriteLine("Please write only numbers, try again.");
            }
            while (num < 0);

            return num;
        }
        public void PrintMenu()
        {
            Console.WriteLine("Please coose 1 from 4 options:");
            Console.WriteLine("1: Addition");
            Console.WriteLine("2: Substraction");
            Console.WriteLine("3: Multiplication");
            Console.WriteLine("4: Division");
        }
        public int getUserChoise()
        {
            int num = 0;
            do
            {
                if (!Int32.TryParse(Console.ReadLine(), out num) || num < 1 || num > 4) Console.WriteLine("Please write only numbers 1, 2, 3 or 4. Try again.");
            }
            while (num < 1 || num > 4);

            return num;
        }
        public double Calculate(int num1, int num2, int operation)
        {
            //double result = 0;

            Dictionary<int, Func<double, double, double>> mathOperations = new Dictionary<int, Func<double, double, double>>();
            mathOperations.Add(1, (double n1, double n2) => { return n1 + n2; });
            mathOperations.Add(2, (double n1, double n2) => { return n1 - n2; });
            mathOperations.Add(3, (double n1, double n2) => { return n1 * n2; });
            mathOperations.Add(4, (double n1, double n2) => { return n1 / n2; });

            /*switch (operation)
            {
                case 1: result = num1 + num2; break;
                case 2: result = num1 - num2; break;
                case 3: result = num1 * num2; break;
                case 4: result = num1 / num2; break;
            }*/
            //return result;            
            return mathOperations[operation](num1, num2);
        }
        public void PrintResultNicely(double rez)
        {
            Console.WriteLine();
            Console.WriteLine(new String('*', rez.ToString().Length + 8));
            Console.WriteLine($"**{new String(' ', rez.ToString().Length + 4)}**");
            Console.WriteLine($"**  {rez}  **");
            Console.WriteLine($"**{new String(' ', rez.ToString().Length + 4)}**");
            Console.WriteLine(new String('*', rez.ToString().Length + 8));
        }

    }
}
