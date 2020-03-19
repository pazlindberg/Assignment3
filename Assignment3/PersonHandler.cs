using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment3
{
    class PersonHandler
    {
        public void PrintPerson(Person p)
        {
            Console.WriteLine("Namn: {0} {1}, ålder: {2}, längd: {3}, vikt: {4}",
                p.FName, p.LName,
                p.Age,
                p.Height,
                p.Weight);
        }

        public void SetAge(Person pers, int age)
        {
            pers.Age = age;
        }

        public void SetFName(Person pers, string fname)
        {
            pers.FName = fname;
        }

        public void SetLName(Person pers, string lname)
        {
            pers.LName = lname;
        }

        public void SetHeight(Person pers, double height)
        {
            pers.Height = height;
        }

        public void SetWeight(Person pers, double weight)
        {
            pers.Weight = weight;
        }

        public Person CreatePerson(int age, string fname, string lname, double height, double weight)
        {
            Person pers = new Person(); //hade kunnat göras i konstruktorn
            SetAge(pers, age);
            SetFName(pers, fname);
            SetLName(pers, lname);
            SetHeight(pers, height);
            SetWeight(pers, weight);

            return (pers);
        }

        

    }
}
