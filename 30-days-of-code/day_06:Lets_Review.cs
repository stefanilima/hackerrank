/*
 * Objective

Today we will expand our knowledge of strings, combining it with what we have already learned about loops.
Check out the Tutorial tab for learning materials and an instructional video.

Task
Given a string, S , of length N that is indexed from 0 to N - 1, print its even-indexed and odd-indexed
characters as  space-separated strings on a single line (see the Sample below for more detail).

Note:  is considered to be an even index.

Example
a = adbecf

Print abc def

Input Format

The first line contains an integer, T (the number of test cases).
Each line  of the  subsequent lines contain a string, .

Output Format

For each String  (where ), print 's even-indexed characters, followed by a space,
followed by 's odd-indexed characters.

Sample Input

2
Hacker
Rank

Sample Output

Hce akr
Rn ak

The even indices are , , and , and the odd indices are , , and .
We then print a single line of  space-separated strings;
the first string contains the ordered characters from 's even indices (),
and the second string contains the ordered characters from 's odd indices ().

The even indices are 0 and 2, and the odd indices are 1 and 3.
We then print a single line of 2 space-separated strings;
the first string contains the ordered characters from 's even indices (),
and the second string contains the ordered characters from 's odd indices ().
 */
using System;
using System.Collections.Generic;
using System.IO;
class Solution
{
    static void Main(String[] args)
    {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
        int T = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < T; i++)
        {
            string S = Console.ReadLine();
            string letrasPares = null;
            string letrasImpares = null;

            for (int j = 0; j < S.Length; j++)
            {
                if (j % 2 == 0)
                {
                    letrasPares += S[j];
                }
                else
                {
                    letrasImpares += S[j];
                }
            }

            Console.WriteLine(letrasPares + " " + letrasImpares);
        }
    }
}