namespace RA_HW_6
{
    public class Point
    {
        int _x;
        int _y;
        string _name;

        public int X
        {
            get { return _x; }
            init { _x = value; }
        }

        public int Y
        {
            get { return _y; }
            init { _y = value; }
        }

        public string Name
        {
            get { return _name; }
            init { _name = value; }
        }

        public Point(int x, int y, string name)
        {
            X = x;
            Y = y;
            Name = name;
        }

        public override string ToString()
        {
            return $"Вершина {Name} ({X}, {Y}).";
        }
    }
}
