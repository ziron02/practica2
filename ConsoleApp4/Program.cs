using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Dictionary<char, int> romanNumerals = new Dictionary<char, int>()
        {
            ['I'] =     1, 
            ['V'] =     5,
            ['X'] =    10,
            ['L'] =    50,
            ['C'] =   100,
            ['D'] =   500,
            ['M'] =  1000
        };
        string str = "CMCML";
        int num = 0;
        for (int i = 0; i < str.Length; i++)
        {
            if (i + 1 < str.Length && romanNumerals[str[i]] < romanNumerals[str[i + 1]])
            {
                num -= romanNumerals[str[i]];
            }
            else
            {
                num += romanNumerals[str[i]];
            }
        }
        Console.WriteLine(num);
    }
}