using System;
using PersonRegister;
using Dictionary;
using System.Collections.Generic;

namespace PersonRegisterTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Register register = new Register("testRegister");

            Job poulJob = new Job("Programmør", "FiksIT", 12402349, 0.0f);
            Person poul = new Person(29, "Poul", "Bach", Gender.Male, poulJob);
            int week = 2;

            register.AddPerson(poul, week);

            register.printRegister();

            DictionaryTask dictionaryTask = new DictionaryTask();

            dictionaryTask.superDic.Add(10, "!");
            dictionaryTask.lmaowtfDic.Add(1.0f, true);

            BonusOpgaveClass opgaveClass = new BonusOpgaveClass("Per", 87);

            Dictionary<BonusOpgaveClass, string> bonusOpgaveDictionary = new Dictionary<BonusOpgaveClass, string>();

            bonusOpgaveDictionary.Add(opgaveClass, "Yeet");
        }
    }
}
