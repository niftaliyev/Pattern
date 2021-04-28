using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalsFabrice
{
    class AnimalWorld
    {
        List<Unit> carnivore = new List<Unit>();
        List<Unit> herbivore = new List<Unit>();
        List<Unit> animals;
        /****************************************************/

        Random Random = new Random();
        public AnimalWorld(List<Unit> animals)
        {
            this.animals = animals;
        }

        /****************************************************/
        public void MealsCarnivore()
        {


            foreach (var item in animals)
            {
                var index = Random.Next(animals.Count);
                if (item is Carnivore == true)
                {
                    if (animals[index] is Herbivore == true)
                    {
                        item.Eat(animals[index]);
                    }
                    else
                    {
                        item.Life--;
                    }
                    

                }
                
            }
            
        }

        /****************************************************/
        public void MealsHerbivore()
        {
            foreach (var item in animals)
            {

                if (item is Herbivore == true)
                {
                    item.Eat(item);
                }

            }           
        }

        /****************************************************/
    }
}
