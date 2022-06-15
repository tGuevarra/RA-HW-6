namespace Volume
{
    public class Box : Shape
    {
        int _h;

        public int H
        {
            get { return _h; }
            init { _h = value; }
        }

        public Box(int h)
        {
            H = h;
        }

        public override double Volume()
        {
            return Math.Pow(_h, 3);
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Куб, его высота = {_h}, объем = {Volume()}");
        }

        public bool Add(Shape shape)
        {
            if (Program.Volume2 - shape.Volume() >= 0)
            {
                Console.WriteLine("Фигура помещается в куб-контейнер");
                Program.Volume2 -= shape.Volume();
                Console.WriteLine($"Оставшийся объем куба-контейнера {Program.Volume2}:");
                return true;
            }
            else
            {
                Console.WriteLine("Фигура не помещается в куб-контейнер");
                return false;
            }
        }
    }
}
