using System;
using PersonRegister;

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
        }
    }
}
