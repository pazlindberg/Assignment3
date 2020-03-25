using System;
using System.Collections.Generic;

namespace Assignment3
{
    class Program
    {
        static void Main(string[] args)
        {
            //1 - nej de är inkapslade
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
                if(animal_iterator is Dog) Console.WriteLine(animal_iterator.Stats());
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


            /* 
             *3.4.11, svar: För att kunna skapa ett gemensamt gränssnitt för flera klasser som ärver av samma basklass. Det innebär
             *              att man kan skriva olika implementationer för olika subklasser av samma metoder - som därmed kan användas
             *              på samma sätt, oavsett implementation.
             * 
             *3.4.12, svar: Se föreg. svar .. samt undvika att skriva dubbelt eftersom enbart enskilda implementationsdetaljer behöver
             *              ..ja, implementeras.. och i den anropande koden behöver man inte fundera så mycket på hur den ska användas
             *              just eftersom gränssnittet implicerar vissa beteenden. Exempel en panel på en bandspelare har alltid en play-
             *              knapp och man behöver inte veta så mycket mer om det underliggande annat än att det är på play man ska trycka.
             *              Instanser av subklasserna kan också hanteras som vore de instanser av basklassen - med flera fördelar; exempelvis
             *              blir det möjligt att skapa samlingar av olika typer genom att sätta datatypen till superklassen.
             *              
             *3.4.13, svar: C# tillåter arv från EN basklass enbart, vilket går att komma runt med interface. Interface tillåter inga definitioner
                            eller privata medlemmar. 

             * 
             * 
             * 
             */

        }
    }
}
