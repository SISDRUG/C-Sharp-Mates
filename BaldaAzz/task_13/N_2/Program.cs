using System;

namespace N_2
{
    delegate double Average(Func<double>[] delegates);

    class Program
    {
        static void Main(string[] args)
        { 
            Func<double>[] myDelegates = new Func<double>[4];
            for (int i = 0; i < myDelegates.Length; i++)
            {
                myDelegates[i] = () => new Random().Next(15);
            }

            Average average = delegate (Func<double>[] delegates)
            {
                double sum = 0;
                
                foreach (var del in delegates)
                {
                    sum += del();
                }
                return sum / delegates.Length;
            };

            Console.WriteLine(average(myDelegates));
        }
    }
}