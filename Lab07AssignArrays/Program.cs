using System;

namespace Lab07AssignArrays
{
    class Program
    {
        static void Main(string[] args)
        { 
            int[] array = ReadArray("Array");

            PrintArray("Array is ", array);

            MinOfArray(array);
            MaxOfArray(array);
            IndexPosition(array);
            ArrayAverageValue(array);
        }

        static int ReadNumber(string label, int defaultValue)
        {
            Console.Write(label);
            string value = Console.ReadLine();
            if (int.TryParse(value, out int result))
            {
                return result;
            }

            return defaultValue;
        }

        static int[] ReadArray(string label)
        {
            int nr = ReadNumber("Array lenght: ", 0);
            int[] array = new int[nr];
            for (int i = 0; i < array.Length; i++)
            {
                int element = ReadNumber($"Element[{i}] is ", 0);
                array[i] = element;
            }

            return array;
        }

        static void PrintArray(string label, int[] array)
        {
            Console.WriteLine();
            string elementList = string.Join(", ", array);
            Console.WriteLine($"{label}= {elementList}");
        }
        
        static void MinOfArray(int[] array)
        {
            int prevNum;
            int minOfArray;

            minOfArray = array[0];

            for (int i = 0; i < array.Length; i++)
            {
                prevNum = array[i];

                if (prevNum < minOfArray)
                {
                    minOfArray = prevNum;
                }
            }

            Console.Write($"Minimum of array is : {minOfArray}");
            Console.WriteLine();
        }

        static void MaxOfArray(int[] array)
        {           
            int prevNum;
            int maxOfArray;

            maxOfArray = array[0];

            for (int i = 0; i < array.Length; i++)
            {
                prevNum = array[i];

                if (prevNum > maxOfArray)
                {
                    maxOfArray = prevNum;
                }
            }

            Console.Write($"Maximum of array is : {maxOfArray}");
            Console.WriteLine();
            Console.WriteLine();
        }

        static void IndexPosition(int[] array)
        {
            Console.Write("Find index position for number: ");
            string value = Console.ReadLine();
            int number = Convert.ToInt32(value);
            bool found = false;

            for (int i = 0; i < array.Length; i++)
            {
                if (number == array[i])
                {
                    found = true;
                    Console.Write($"Number {number} found at index {i}.");
                    break;
                }
            }

            if (!found)
            {
                Console.Write("Number not found in array");
            }

            Console.WriteLine();
            Console.WriteLine();
        }

        static void ArrayAverageValue(int[] array)
        {
            int sum = 0;

            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }

            Console.Write($"Average value of the array is {(double) sum / array.Length}");
            Console.WriteLine();
        }
    }
}
