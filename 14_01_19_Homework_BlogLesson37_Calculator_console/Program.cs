using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_01_19_Homework_BlogLesson37_Calculator_console
{
    class Program
    {
        static private SimpleCalculator currentSimpleCalc = new SimpleCalculator();
        static private AtomicCalculator currentAtomicCalc = new AtomicCalculator();
        static void Main(string[] args)
        {
            currentAtomicCalc.GetNumberFromUser += currentSimpleCalc.NumberGetter;
            currentAtomicCalc.MenuPrinter += currentSimpleCalc.PrintMenu;
            currentAtomicCalc.GetUserChoice += currentSimpleCalc.getUserChoise;
            currentAtomicCalc.Calculate += currentSimpleCalc.Calculate;
            currentAtomicCalc.ResultPrinter += currentSimpleCalc.PrintResultNicely;
            currentAtomicCalc.ResultPrinter += (double n) => 
                {
                    Console.WriteLine("\n--------------------------------\n");
                    Console.WriteLine(new String('+', n.ToString().Length + 10));
                    Console.WriteLine($"++{new String(' ', n.ToString().Length + 6)}++");
                    Console.WriteLine($"++   {n}   ++");
                    Console.WriteLine($"++{new String(' ', n.ToString().Length + 6)}++");
                    Console.WriteLine(new String('+', n.ToString().Length + 10));
                };

            currentAtomicCalc.Run();



            Console.ReadKey();
        }
    }
}
