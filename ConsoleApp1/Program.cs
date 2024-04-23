using System;

class Program
{
    static void Main()
    {
        /* задание 1
        string J = "драгоценности";
        string S = "камнид";
        char[] arr1 = J.ToCharArray();   
        char[] arr2 = S.ToCharArray();
        int count = 0;
        for (int i = 0; i < arr1.Length; i++)
        {
            for (int j = 0; j < arr2.Length; j++)
            {
                if (arr2[j] == arr1[i])
                {
                    count++;
                }
            }
        }

        Console.WriteLine(count);
        */
        
        /* 2 задание
        int[] candidates = { 2, 5, 7, 3, 1, 7 };
        int target = 10;
        for (int i = 0; i < candidates.Length - 1; i++)
        {
            for (int j = i + 1; j < candidates.Length; j++)
            {
                if (candidates[i] + candidates[j] == target)
                {
                    Console.WriteLine($"{candidates[i]} + {candidates[j]} = {target}");  
                }
            }
        }
        */

        /* 3 задание
        int[] nums = { 1, 1, 2, 3, 4, 5, 6 };
        bool count = false;
        for (int i = 0; i < nums.Length - 1; i++)
        {
            for (int j = i + 1; j < nums.Length; j++)
            {
                if (nums[i] == nums[j])
                {
                    count = true;
                }
            }
        }

        Console.WriteLine(count);
        */
        
        
        int[] candidates = { 2, 5, 7, 3, 1, 7 };
        int target = 10;
        for (int i = 0; i < candidates.Length - 1; i++)
        {
            for (int j = i + 1; j < candidates.Length; j++)
            {
                if (candidates[i] + candidates[j] == target)
                {
                    Console.WriteLine($"{candidates[i]} + {candidates[j]} = {target}");  
                }
            }
        }
        
    }
}