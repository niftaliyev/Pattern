using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalsFabrice
{
    public class Wolf : Carnivore
    {
        public override string ToString()
        {
            return $"Wolf {Life}"; 
        }
    }

    public class Tigr : Carnivore
    {
        public override string ToString()
        {
            return $"Tigr {Life}";
        }
    }


    public class Leon : Carnivore
    {
        public override string ToString()
        {
            return $"Leon {Life}";
        }
    }

    public class Los : Herbivore
    {
        public Los()
        {
            Life = 10;
            Weigth = 50;
        }
        public override string ToString()
        {
            return $"Los {Life}";
        }
    }

    public class Elk : Herbivore
    {
        public Elk()
        {
            Life = 10;
            Weigth = 50;
        }
        public override string ToString()
        {

            return $"Elk {Life}";
        }
    }



    public class Hare : Herbivore
    {
        public Hare()
        {
            Life = 10;
            Weigth = 50;
        }
        public override string ToString()
        {
            return $"Hare {Life}";
        }
    }
}
