namespace N_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<double, double, double> operations = new((x, y) => x + y);
            operations += (x, y) => x - y;
            operations += (x, y) => 
            {
                if(y == 0) throw new DivideByZeroException("Произошло деление на ноль!");
                return x / y;
            };

            Console.WriteLine(operations(2, 1));
        }
    }
}