namespace LargestNumber
{
    class Program
    {
        static void largest(int x, int y, int z)
        {
            int max = x;

            if (x >= y && x >= z)
                max = x;
            if (y >= x && y >= z)
                max = y;
            if (z >= x && z >= y)
                max = z;

            Console.WriteLine("largest number among {0}, {1} and {2} is: {3}",x, y, z, max);
        }

        static void Main(string[] args)
        {
            largest(100, 50, 25);
            largest(50, 50, 75);
            largest(20, 50, 30);
        }
    }
}