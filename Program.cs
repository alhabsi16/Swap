namespace swap1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //swap a and b
            int a = 5;
            int b = 9;
            
            (a , b) = (b , a);
            Console.WriteLine("a = " + a);
            Console.WriteLine("b = " + b);

            //swap hello and world
            string d = "hello";
            string e = "world";

            (d, e) = (e, d);

            Console.WriteLine("********************************");
            Console.WriteLine(d);
            Console.WriteLine(e);

        }
    }
}
        