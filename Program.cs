namespace swap1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //swap a and b
            int a = 5;
            int b = 9;
            int c = 0;

            c = a;
            a = b;
            b = c;
            Console.WriteLine("a = " + a);
            Console.WriteLine("b = " + b);

            //swap hello and world
            string d = "hello";
            string e = "world";
            string f = "";

            f = d;
            d = e;
            e = f;

            Console.WriteLine("********************************");
            Console.WriteLine(d);
            Console.WriteLine(e);

        }
    }
}
        