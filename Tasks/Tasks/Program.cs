using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1.Data Types & Variables:

            int number = 5;
            double bignumber = 5.14;
            bool boolean = false;
            char c = 'a';
            string word = "hello world!";
            Console.WriteLine(number);
            Console.WriteLine(bignumber);
            Console.WriteLine(boolean);
            Console.WriteLine(c);
            Console.WriteLine(word);
            Console.WriteLine();
            Console.WriteLine("Integer data type`s size : " + sizeof(int));
            Console.WriteLine("Float data type`s size : " + sizeof(float));
            Console.WriteLine("Boolean data type`s size : " + sizeof(bool));

            //2. Conditional Statements: 

            int x = Convert.ToInt32(Console.ReadLine());
            if (x % 2 == 0)
                Console.WriteLine("The entered number is even");
            else
                Console.WriteLine("The entered number is odd");

            //3.Loops:

            for (int i = 1; i < 10; i++)
                if (i % 3 == 0)
                    Console.Write(i + " ");

            //4.Arrays:

            int[] array = new int[10] { 1, 3, 5, 7, 1, 2, 31, 10, 9, 0 };
            int max = array[0];
            int min = array[0];

            foreach (int i in array)
            {
                if (i > max)
                    max = i;
                if (i < min)
                    min = i;
            }
            Console.WriteLine("The maximum number in array is " + max);
            Console.WriteLine("The minimum number in array is " + min);

            //5.Arithmetic Operators:

            int number1 = Convert.ToInt32(Console.ReadLine());
            int number2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine((number1 + number2) / number2);

            //6. Loops with Conditions:

            int number_input;
            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out number_input))
                {
                    break;
                }
            }

            //7.Functions & Methods:

            int number3 = Convert.ToInt32((Console.ReadLine()));
            int number4 = Convert.ToInt32((Console.ReadLine()));
            int sum_of = sum(number3, number4);
            Console.WriteLine(sum_of);
            int difference_of = difference(number3, number4);
            Console.WriteLine(difference_of);

            //8.Switch Case:

            int operation = Convert.ToInt32(Console.ReadLine());
            int calc1 = Convert.ToInt32(Console.ReadLine());
            int calc2 = Convert.ToInt32(Console.ReadLine());

            switch (operation)
            {
                case 1:
                    Console.WriteLine(calc1 + calc2);
                    break;
                case 2:
                    Console.WriteLine(calc1 - calc2);
                    break;
                case 3:
                    Console.WriteLine(calc1 * calc2);
                    break;
                case 4:
                    Console.WriteLine(calc1 / calc2);
                    break;

            }

            //9.Switch case

            int season = Convert.ToInt32(Console.ReadLine());

            switch (season)
            {
                case 1:
                    Console.WriteLine("Spring");
                    break;
                case 2:
                    Console.WriteLine("Summer");
                    break;
                case 3:
                    Console.WriteLine("Fall");
                    break;
                case 4:
                    Console.WriteLine("Winter");
                    break;
            }

        }
        //Functions
        static int sum(int a, int b)
        {
            return a + b;
        }
        static int difference(int a, int b)
        {
            return a - b;
        }
        static int product(int a, int b)
        {
            return a * b;
        }
        static int quotient(int a, int b)
        {
            return a % b;
        }
    }
}
