namespace Volume
{
    public class Cylinder : Shape
    {
        int _h;
        int _r;

        public int H
        {
            get { return _h; }
            init { _h = value; }
        }

        public int R
        {
            get { return _r; }
            init { _r = value; }
        }

        public Cylinder(int h, int r)
        {
            H = h;
            R = r;
        }

        public override double Volume()
        {
            return Math.PI * Math.Pow(_r, 2) * _h;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Цилиндр, его высота {_h}, радиус {_r} и объем = {Volume()}");
        }
    }
}
