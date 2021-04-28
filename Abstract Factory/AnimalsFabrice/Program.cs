using System;
using System.Collections.Generic;

namespace AnimalsFabrice
{

    class Program
    {
        static void Main(string[] args)
        {
            List<Unit> animals = new List<Unit>();
           
            AnimalWorld animalWorld = new AnimalWorld(animals);


            IContinent continent = new Africa();


            animals.Add(continent.CreateCarnivore());
            animals.Add(continent.CreateHerbivore());


            continent = new NorthAmerica();

            animals.Add(continent.CreateCarnivore());
            animals.Add(continent.CreateHerbivore());


            continent = new Evrasia();

            animals.Add(continent.CreateCarnivore());
            animals.Add(continent.CreateHerbivore());




            animalWorld.MealsCarnivore();


            animalWorld.MealsHerbivore();

            foreach (var item in animals)
            {
                //Console.WriteLine(item);
            }







        }
    }
}
