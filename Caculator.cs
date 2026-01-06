using System;

namespace ForLoopAssignment
{
    class NumberCalculator
    {
        public void ShowAndSum(int n)
        {
            int sum = 0;
            Console.Write("แสดงตัวเลข: ");

            for (int i = 1; i <= n; i++)
            {
                Console.Write(i + " ");
                sum += i;
            }

            Console.WriteLine();
            Console.WriteLine("ผลรวม = " + sum);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("ป้อนตัวเลข: ");
            int inputNumber = int.Parse(Console.ReadLine());

            NumberCalculator calculator = new NumberCalculator();
            calculator.ShowAndSum(inputNumber);

            Console.ReadKey();
        }
    }
}
