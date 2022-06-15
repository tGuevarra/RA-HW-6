namespace RA_HW_6
{
    public class Program
    {
        public static void Main()
        {
            Console.Clear();
            Console.Write("Введите количество вершин от 3 до 5: ");
            int number = int.Parse(Console.ReadLine());

            Point[] points = new Point[number];
            for (int i = 0; i < points.Length; i++)
            {
                Console.Write($"Введите название вершины {i + 1} (a,b,c и т.д.): ");
                string name = Console.ReadLine();

                Console.Write($"Введите вершину координаты x{i + 1} : ");
                int x = int.Parse(Console.ReadLine());

                Console.Write($"Введите вершину координаты y{i + 1} : ");
                int y = int.Parse(Console.ReadLine());

                points[i] = new Point(x, y, name);
            }

            Polygon polygon = new(points);

            foreach (var item in polygon.Vertex)
            {
                Console.WriteLine(item.ToString());
            }

            Console.WriteLine($"Периметр {polygon.Name()}: равен {polygon.Perimeter()}");
            Console.ReadLine();
        }
    }
}