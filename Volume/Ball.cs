namespace Volume
{
    public class Ball : Shape
    {
        int _r;

        public int R
        {
            get { return _r; }
            init { _r = value; }
        }

        public Ball(int r)
        {
            R = r;
        }

        public override double Volume()
        {
            return 4 * Math.PI * Math.Pow(_r, 3) / 3;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Шар, его радиус {_r} и объем = {Volume()}");
        }
    }
}
