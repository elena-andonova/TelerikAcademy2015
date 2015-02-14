using System;


namespace _12.ZeroSubset
{
    class ZeroSubset
    {
        static void Main()
        {
            //We are given 5 integer numbers. Write a program that finds all subsets of these numbers whose sum is 0.
            //Assume that repeating the same subset several times is not a problem.

            Console.Write("Please enter 5 numbers:");
            string input = Console.ReadLine();
            string[] strArr = input.Split(' ');
            int[] nums = new int[strArr.Length];
            int[] subset = new int[nums.Length];
            for (int i = 0; i < strArr.Length; i++)
            {
                nums[i] = int.Parse(strArr[i]);
            }

            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == 0)
                    {
                        Console.WriteLine("{0} + {1} = 0", nums[i], nums[j]);
                        continue;
                    }
                }
            }

            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    for (int k = j + 1; k < nums.Length; k++)
                    {
                        if (nums[i] + nums[j] + nums[k] == 0)
                        {
                            Console.WriteLine("{0} + {1} + {2} = 0", nums[i], nums[j], nums[k]);                            
                        }
                    }
                }
            }

            
            if (nums[0] + nums[1] + nums[2] + nums[3] == 0)
            {
                Console.WriteLine("{0} + {1} + {2} + {3} = 0", nums[0], nums[1], nums[2], nums[3]);
            }
            if (nums[1] + nums[2] + nums[3] + nums[4] == 0)
            {
                Console.WriteLine("{0} + {1} + {2} + {3} = 0", nums[1], nums[2], nums[3], nums[4]);
            }
            if (nums[0] + nums[1] + nums[2] + nums[3] + nums[4] == 0)
            {
                Console.WriteLine("{0} + {1} + {2} + {3} + {4} = 0", nums[0], nums[1], nums[2], nums[3], nums[4]);
            }
            else
            {
                Console.WriteLine("no zero subset");
            }
        }
    }
}
