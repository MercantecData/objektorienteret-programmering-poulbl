using System;
using PersonRegister;
using Dictionary;
using MathOverload;
using System.Collections.Generic;
using System.Net.Http.Headers;

namespace PersonRegisterTest
{
    class Program
    {
        static void Main(string[] args)
        {

            // REGISTER
            Register register = new Register("testRegister");

            Job poulJob = new Job("Programmør", "FiksIT", 12402349, 0.0f);
            Person poul = new Person(29, "Poul", "Bach", Gender.Male, poulJob);
            int week = 2;

            register.AddPerson(poul, week);

            register.printRegister();


            //DICTIONARY
            DictionaryTask dictionaryTask = new DictionaryTask();

            dictionaryTask.superDic.Add(10, "!");
            dictionaryTask.lmaowtfDic.Add(1.0f, true);

            BonusOpgaveClass opgaveClass = new BonusOpgaveClass("Per", 87);

            Dictionary<BonusOpgaveClass, string> bonusOpgaveDictionary = new Dictionary<BonusOpgaveClass, string>();

            bonusOpgaveDictionary.Add(opgaveClass, "Yeet");


            //MATH
            Calculator calc = new Calculator();

            Console.WriteLine("Add int: " + calc.Add(13, 2));
            Console.WriteLine("Add float: " + calc.Add(2.0f, 1.0f));
            Console.WriteLine("Add string: " + calc.Add("2", "5"));
            Console.WriteLine("Subtract int: " + calc.Subtract(13, 2));
            Console.WriteLine("Subtract float: " + calc.Subtract(2.0f, 1.0f));
            Console.WriteLine("Subtract string: " + calc.Subtract("2", "5"));
            Console.WriteLine("Multiply int: " + calc.Multiply(13, 2));
            Console.WriteLine("Multiply float: " + calc.Multiply(2.0f, 1.0f));
            Console.WriteLine("Multiply string: " + calc.Multiply("2", "5"));
            Console.WriteLine("Divide int: " + calc.Divide(13, 2));
            Console.WriteLine("Divide float: " + calc.Divide(2.0f, 1.0f));
            Console.WriteLine("Divide string: " + calc.Divide("2", "5"));

            Console.WriteLine("Square int: " + calc.Square(13));
            Console.WriteLine("Square float: " + calc.Square(2.0f));
            Console.WriteLine("Square string: " + calc.Square("5"));



        }
    }
}
