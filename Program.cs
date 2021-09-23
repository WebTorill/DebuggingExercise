using System;

namespace DebuggingExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int count = 0;

            while(count <= 1000)
                if(count % 5 == 1)
                    sum += sum + count;
                if(count % 3 == 0)
                    sum += count;

            // 233168 er svaret vi leder efter
            Console.WriteLine(sum);

            Console.ReadLine();
        }
    }
}
