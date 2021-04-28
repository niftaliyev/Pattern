using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalsFabrice
{
    /****************************************************/
    public abstract class Unit
    {
        public int Life { get; set; }
        public int Weigth { get; set; }
        abstract public void Eat(Unit target);

    }
    /*************** ANIMALS TYPE FOR CREATE *************/

    public abstract class Herbivore : Unit
    {
        public Herbivore()
        {
            Life = 100;
            Weigth = 100;
        }
        public override void Eat(Unit target)
        {
            target.Life++;
        }
    }

    /****************************************************/
    public class Carnivore : Unit
    {
        public override void Eat(Unit target)
        {
            if (target.Life > 0)
            {
                Life += target.Weigth;
                target.Life -= 10;
            }

        }
    }

    /****************************************************/
}
