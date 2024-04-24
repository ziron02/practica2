using System;
using System.Collections.Generic;

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
        int[] candidates = { 10, 1, 2, 7, 6, 1, 5 };
        int target = 8;

        List<List<int>> result = FindCombinations(candidates, target);

        Console.WriteLine("Result:");
        foreach (var combination in result)
        {
            Console.Write("");
            foreach (var num in combination)
            {
                Console.Write(num + " ");
            }

            Console.WriteLine("");
        }

        static List<List<int>> FindCombinations(int[] candidates, int target)
    {
        List<List<int>> result = new List<List<int>>();
        Array.Sort(candidates);
        Backtrack(candidates, target, 0, new List<int>(), result);
        return result;
    }

    static void Backtrack(int[] candidates, int target, int start, List<int> tempList, List<List<int>> result)
    {
        if (target == 0)
        {
            result.Add(new List<int>(tempList));
            return;
        }

        for (int i = start; i < candidates.Length; i++)
        {
            if (i > start && candidates[i] == candidates[i - 1])
                continue;

            if (candidates[i] > target)
                break;

            tempList.Add(candidates[i]);
            Backtrack(candidates, target - candidates[i], i + 1, tempList, result);
            tempList.RemoveAt(tempList.Count - 1);
        }
    }*/

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
    }
}