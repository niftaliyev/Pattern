using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalsFabrice
{
    /****************************************************/
    public class Evrasia : IContinent
    {
        public Carnivore CreateCarnivore()
        {
            return new Tigr();
        }

        public Herbivore CreateHerbivore()
        {
            return new Los();
        }
    }

    /****************************************************/
    public class Africa : IContinent
    {
        public Carnivore CreateCarnivore()
        {
            return new Leon();
        }

        public Herbivore CreateHerbivore()
        {
            return new Hare();
        }
    }

    /****************************************************/
    public class NorthAmerica : IContinent
    {
        public Carnivore CreateCarnivore()
        {

            return new Wolf();
        }

        public Herbivore CreateHerbivore()
        {

            return new Elk();
        }

    }

    /****************************************************/
}
