using System;
using System.Collections.Generic;

namespace Dictionary
{
    public class DictionaryTask
    {
        public Dictionary<int, string> superDic = new Dictionary<int, string>()
        {
            {0, "Der" },
            {1, "Var" },
            {2, "Engang" },
            {3, "Et" },
            {4, "Lille" },
            {5, "Dictionary" },
            {6, "Som" },
            {7, "Ikke" },
            {8, "Kunne" },
            {9, "Noget" }
        };

        public Dictionary<float, bool> lmaowtfDic = new Dictionary<float, bool>()
        {
            {0.0f, true },
            {0.3f, true },
            {0.8f, true },
            {0.5f, false },
            {0.4f, false },
            {0.6f, true },
            {0.1f, false },
            {0.9f, true },
            {0.2f, false },
        };


        public DictionaryTask()
        {
        }


    }

    public class BonusOpgaveClass
    {
        public string name;
        public int age;

        public BonusOpgaveClass(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
    }
}
