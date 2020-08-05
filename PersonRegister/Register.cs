using System;
using System.Collections.Generic;

namespace PersonRegister
{

    public struct RegisteredPerson
    {
        public Person person { get; }
        public int week { get; }

        public RegisteredPerson(Person person, int week)
        {
            this.person = person;
            this.week = week;
        }
    }

    public class Register
    {
        private List<RegisteredPerson> persons { get; }
        private int nrOfPersons;
        private string name; //?

        public int getNrOfPersons()
        {
            nrOfPersons = persons.Count;
            return nrOfPersons;
        }

        public void AddPerson(Person person, int week)
        {
            RegisteredPerson regPerson = new RegisteredPerson(person, week);
            persons.Add(regPerson);
        }
        public void AddPerson(RegisteredPerson regPerson)
        {
            persons.Add(regPerson);
        }

        public void RemovePerson(RegisteredPerson person)
        {
            persons.Remove(person);
        }

        public void RemoveAllPerson()
        {
            persons.Clear();
        }

        public void printRegister()
        {
            Console.WriteLine("Number of registered persons: " + getNrOfPersons());
            foreach(RegisteredPerson p in persons)
            {
                Console.WriteLine("--------------------------------");
                Console.WriteLine("Name: " + p.person.firstName + " " + p.person.lastName);
                Console.WriteLine("Age: " + p.person.age);
                Console.WriteLine("Gender: " + p.person.gender);
            }
            Console.WriteLine("DONE PRINTING");
        }

        public Register(string name)
        {
            persons = new List<RegisteredPerson>();
            this.name = name;
        }
    }
}
