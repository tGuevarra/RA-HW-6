namespace Volume
{
    public class Program
    {
        static double Volume1;
        public static double Volume2
        {
            get { return Volume1; }
            set { Volume1 = value; }
        }
        public static void Main()
        {
            Console.Clear();
            Console.Write("Введите сторону куба: ");
            int side = int.Parse(Console.ReadLine());

            Box container = new Box(side);
            Console.WriteLine($"Объем равен: {container.Volume()}");

            Volume1 = container.Volume();

            List<Shape> shape = new();

            Shape s;
            bool isOk;

            do
            {
                Console.Write("Добавьте фигуру (1 - куб, 2 - цилиндр, 3 - пирамида, 4 - шар): ");

                s = AddShape(Console.ReadLine());

                isOk = container.Add(s);

                if (isOk)
                {
                    shape.Add(s);
                }
            } while (isOk);

            Console.WriteLine($"Вы положили в куб контейнер {shape.Count} фигур:");
            for (int i = 0; i < shape.Count; i++)
            {
                Console.Write($"{i + 1}. ");
                shape[i].DisplayInfo();
            }
            Console.WriteLine($"Оставшийся объем: {Volume1}");

            Console.ReadLine();
        }

        public static Shape AddShape(string type)
        {
            switch (type)
            {
                case "1":
                    {
                        Console.Write("Введите сторону куба: ");
                        return new Box(int.Parse(Console.ReadLine()));
                    }
                case "2":
                    {
                        Console.Write("Введите радиус цилиндра: ");
                        int r = int.Parse(Console.ReadLine());
                        Console.Write("Введите высоту цилиндра: ");
                        int h = int.Parse(Console.ReadLine());
                        return new Cylinder(h, r);
                    }
                case "3":
                    {
                        Console.Write("Введите площадь основания пирамиды: ");
                        int s = int.Parse(Console.ReadLine());
                        Console.Write("Введите высоту пирамиды: ");
                        int h = int.Parse(Console.ReadLine());
                        return new Pyramid(h, s);
                    }
                case "4":
                    {
                        Console.Write("Введите радиус шара: ");
                        return new Ball(int.Parse(Console.ReadLine()));
                    }
                default:
                    {
                        return null;
                    }

            }
        }
    }
}