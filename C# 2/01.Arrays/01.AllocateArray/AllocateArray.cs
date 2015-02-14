using System;

namespace _01.AllocateArray
{
    class AllocateArray
    {
        static void Main()
        {        
    //Write a program that allocates array of 20 integers and initializes each element by its index multiplied by 5.
    //Print the obtained array on the console.
            int[] arr = new int[20];

            for (int i = 0; i <arr.Length; i++)
            {
                arr[i] = i * 5;
            }

            Console.WriteLine(String.Join(", ", arr));
        }
    }
}
