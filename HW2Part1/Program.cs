/// Chapter No. 2		Exercise No. 1
/// File Name: HW2Part1.cs
/// @author: Jacques Zwielich 
/// Date:  September 13, 2020
///
/// Problem Statement: Take a first and last name and make it into pig latin
/// 
/// 
/// 
/// Overall Plan:
/// 1) Store a first and last name
/// 2) Create a temporary variable and store each letter except for the first
/// 3) Add the first letter to the end of the new string and add ay
/// 4) Print out both first and last name out to the console

using System;

namespace HW2Part1
{
    class Program
    {
        static void Main(string[] args)
        {
            String first = "Jacques";
            String last = "Zwielich";
            String tmp = "";
            //Loop through all characters of first string except for the first
            for (int i = 1; i < first.Length; i++)
            {
                tmp += first[i];
            }
            //Take the new string append the first letter of first and add ay
            first = tmp + first[0] + "ay";
            tmp = "";
            //Loop through all characters of last string except for the first
            for (int i = 1; i < last.Length; i++)
            {
                tmp += last[i];
            }
            //Take the new string append the first letter of last and add ay
            last = tmp + last[0] + "ay";
            //print out the both variables with a space between them
            Console.WriteLine(first + " " + last);
        }
    }
}
