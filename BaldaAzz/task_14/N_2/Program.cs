namespace N_2
{
    class Program
    {
        static void PrintResult(Func<double, double, double> del, double x, double y)
        {
            Console.WriteLine(del(x, y));
        }

        static void Main(string[] args)
        {
            Func<double, double, double> operations = new((x, y) => x + y);
            operations += (x, y) => x - y;
            operations += (x, y) => 
            {
                if(y == 0) throw new DivideByZeroException("Произошло деление на ноль!");
                return x / y;
            };

            PrintResult(operations, 12, 13);
        }
    }
}