using System;

namespace TestFunction
{
    class MainClass
    {
        public static int triArea(int width, int height)
        {
            return (width * height) / 2;
        }
        public static int Summ(int a, int b)
        {
            int c = a + b;
            return c;
        }
        public static void Main(string[] args)
        {
            int x = 33;
            int y = 22;
            int z = Summ(x, y);
            Console.WriteLine(z);
        }
    }
}
