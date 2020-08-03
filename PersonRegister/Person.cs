using System;
using System.Collections.Generic;
using System.Text;

namespace PersonRegister
{
    public enum Gender
    {
        Male,
        Female
    }
    public class Person
    {
        public int age;
        public string firstName;
        public string lastName;
        public Gender gender;
        public Job job;

        public Person()
        {
        }

        public Person(int age, string firstName, string lastName, Gender gender, Job job)
        {
            this.age = age;
            this.firstName = firstName;
            this.lastName = lastName;
            this.gender = gender;
            this.job = job;
        }
    }
}
