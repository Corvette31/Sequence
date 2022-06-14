using System;

namespace Sequence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //По условию задачи дано стартовое число в нашем случае 5,
            //и последовательность чисел, где каждое следующее число
            //на 7 больше предыдущего, и ограничением последовательности не более 100
            int stratNumber = 5;
            int increment = 7;
            int maxValue = 100;

            for (int i = stratNumber; i < maxValue; i += increment)
            {
                Console.Write($"{i} ");
            }
        }
    }
}
