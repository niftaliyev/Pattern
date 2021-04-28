using System;
using System.Collections.Generic;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IFigureCreator> figures = new List<IFigureCreator>();

            figures.Add(new LFormFactory());
            figures.Add(new TFormFactory());
            figures.Add(new JFormFactory());

            List<Figure> figure = new List<Figure>();
            Random random = new Random();

            for (int i = 0; i < 10; i++)
            {
                int index = random.Next(figures.Count);
                Figure figure1 = figures[index].Create();
                figure.Add(figure1);
            }

            foreach (var item in figure)
            {
                Console.WriteLine(item);
            }
        }
    }
}
