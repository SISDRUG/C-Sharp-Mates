namespace N_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<int, int, int> Add = (a, b) => a + b;
            Func<int, int, int> Sub = (a, b) => a - b;
            Func<int, int, int> Mul = (a, b) => a * b;
            Func<int, int, int> Div = (a, b) =>
            {
                if (b == 0) throw new DivideByZeroException();
                return a / b;
            };

            Console.WriteLine(Add(1, 2));
            Console.WriteLine(Sub(1, 2));
            Console.WriteLine(Mul(1, 2));
            Console.WriteLine(Div(1, 2));
        }
    }
}