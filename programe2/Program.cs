using System;
using System.Diagnostics.Metrics;
using System.Runtime.InteropServices.Marshalling;

namespace programe2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            char letter = ' ';
            List<int> numbers = new List<int>();
            do
            {
                Console.WriteLine("P - Print numbers");
                Console.WriteLine("A - Add a number");
                Console.WriteLine("M - Display mean of the numbers");
                Console.WriteLine("S - Display the smallest number");
                Console.WriteLine("L - Display the largest number");
                Console.WriteLine("Q - Quit");
                Console.WriteLine("__________________________________");
                Console.WriteLine("please enter your letter : ");
                letter = Convert.ToChar(Console.ReadLine());
                double sum = 0;
                int largeNumber = 0;
                // print list 
                if (letter == 'p')
                {

                    if (numbers.Count != 0)
                    {

                        for (int i = 0; i < numbers.Count - 1; i++)
                        {
                            for (int j = 0; j < numbers.Count - 1 - i; j++)
                            {
                                if (numbers[j] > numbers[j + 1])
                                {
                                    // Swap the elements
                                    int temp = numbers[j];
                                    numbers[j] = numbers[j + 1];
                                    numbers[j + 1] = temp;
                                }
                            }
                        }
                        for (int i = 0; i < numbers.Count; i++)
                        {
                            if (i == 0)
                                Console.Write("[ ");
                            Console.Write($"{numbers[i]} ");
                        }
                        Console.Write("]");
                        Console.WriteLine();
                    }
                    else
                    {
                        Console.WriteLine("this list is empty");
                    }
                }
                // add number of list 
                else if (letter == 'a')
                {
                    int num = Convert.ToInt32(Console.ReadLine());    
                    numbers.Add(num);
                    Console.WriteLine($"number is added {num}");
                }
                // print averge number 
                else if (letter == 'm')
                {
                    for (int i = 0; i < numbers.Count; i++)
                    {
                        sum += numbers[i];
                    }
                    Console.WriteLine(sum / numbers.Count);
                }
                // print large number in list 
                else if (letter == 'l')
                {

                    for (int i = 0; i < numbers.Count; i++)
                    {
                        if (numbers[i] > largeNumber)
                            largeNumber = numbers[i];


                    }
                    Console.WriteLine(largeNumber);
                }
                // print small number in list 
                else if (letter == 's')
                {
                    int smallNumber = numbers[0];
                    for (int i = 0; i < numbers.Count; i++)
                    {
                        if (numbers[i] < smallNumber)
                            smallNumber = numbers[i];
                    }
                    Console.WriteLine(smallNumber);
                }
                //clear All List 
                else if (letter == 'c')
                {
                    numbers.Clear();
                }
                else if (letter == 'Q')
                    Console.WriteLine("Goodbye...");


            } while (letter != 'Q');


        }
    }
}
