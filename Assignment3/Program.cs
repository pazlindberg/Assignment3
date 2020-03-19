using System;
using System.Collections.Generic;

namespace Assignment3
{
    class Program
    {
        static void Main(string[] args)
        {
            //1 - nej de är inkapslade
            //Person anderz = new Person();
            PersonHandler ph = new PersonHandler();
            Person anderz = ph.CreatePerson(37, "Anderz", "Lindberg", 180, 65);
            ph.PrintPerson(anderz);

            //3.2.8: Bird
            //3.2.9: Animal

            List<Animal> Animals = new List<Animal>();

            Animals.Add(new Swan(10, "anderz1", 3.1415, "pirates lang", "att angöra en brygga"));
            Animals.Add(new Dog(100,"anderz2",0.001,"inföding"));
            Animals.Add(new Worm(1, "kalle", 2, false));

            /*
             *  3.3.11: Listan skapas tom, varpå objekt adderas mha varje klass konstruktorer (och de anropade bas-konstruktorerna i dem) varefter följande loop stegar igenom listan med en iterator
                (och skriver ut statsen för varje instans):
             */

            foreach(Animal animal_iterator in Animals) Console.WriteLine(animal_iterator.Stats());

            foreach (Animal animal_iterator in Animals)
            {
                if(animal_iterator is Dog)
                Console.WriteLine(animal_iterator.Stats());
                //animal_iterator.SayObama(); 3.3.15: därför att typen är Animal.. En Animal är INTE en Dog men en Dog är en Animal.
            }

            foreach (Animal animal_iterator in Animals)
            {
                if (animal_iterator is Dog)
                {
                    Dog d = (Dog)animal_iterator;
                    Console.WriteLine(d.Stats() + d.SayObama());
                }
            }


            List < UserError > UserErrors = new List<UserError>();
            UserErrors.Add(new TextInputError());
            UserErrors.Add(new NumericInputError());

            UserErrors.Add(new ShitBehindKeyboardError());
            UserErrors.Add(new WeatherError());
            UserErrors.Add(new MomError());

            foreach(UserError u in UserErrors)
            {
                Console.WriteLine(u.UEMessage());
            }

        }
    }
}
