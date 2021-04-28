namespace FactoryMethod
{
    abstract class Figure
    {
        public string FigureForm { get; set; }


        public override string ToString()
        {
            return FigureForm;
        }
    }
}
