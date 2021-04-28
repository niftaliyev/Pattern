namespace FactoryMethod
{
    interface IFigureCreator
    {
        Figure Create();

    }

    class LFormFactory : IFigureCreator
    {
        public Figure Create()
        {
            Figure figure = new LForm();
            return figure;
        }
    }
    class TFormFactory : IFigureCreator
    {
        public Figure Create()
        {
            Figure figure = new TForm();
            return figure;
        }
    }

    class JFormFactory : IFigureCreator
    {
        public Figure Create()
        {
            Figure figure = new JForm();
            return figure;
        }
    }
}
