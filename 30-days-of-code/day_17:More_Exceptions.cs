﻿/**
Objective
Yesterday's challenge taught you to manage exceptional situations by using try and catch blocks.
In today's challenge, you will practice throwing and propagating an exception.
Check out the Tutorial tab for learning materials and an instructional video.

Task
Write a Calculator class with a single method: int power(int,int).
The power method takes two integers,  and , as parameters and returns the integer result of .
If either  or  is negative, then the method must throw an exception with the message: n and p should be non-negative.

Note: Do not use an access modifier (e.g.: public) in the declaration for your Calculator class.

Input Format

Input from stdin is handled for you by the locked stub code in your editor.
The first line contains an integer, , the number of test cases.
Each of the  subsequent lines describes a test case in  space-separated integers that denote  and , respectively.

Constraints

No Test Case will result in overflow for correctly written code.
Output Format

Output to stdout is handled for you by the locked stub code in your editor.
There are  lines of output, where each line contains the result of  as calculated by your
Calculator class' power method.

Sample Input

4
3 5
2 4
-1 -2
-1 3
Sample Output

243
16
n and p should be non-negative
n and p should be non-negative
Explanation


:  and  are positive, so power returns the result of , which is .
:  and  are positive, so power returns the result of =, which is .
: Both inputs ( and ) are negative, so power throws an exception and  is printed.
: One of the inputs () is negative, so power throws an exception and  is printed.
 */
using System;

//Write your code here
class Calculator
{
    public int power(int n, int p)
    {
        if (n < 0 || p < 0)
        {
            throw new Exception("n and p should be non-negative");
        }

        return Convert.ToInt32(Math.Pow(n, p));
    }
}

class Solution
{
    static void Main(String[] args)
    {
        Calculator myCalculator = new Calculator();
        int T = Int32.Parse(Console.ReadLine());
        while (T-- > 0)
        {
            string[] num = Console.ReadLine().Split();
            int n = int.Parse(num[0]);
            int p = int.Parse(num[1]);
            try
            {
                int ans = myCalculator.power(n, p);
                Console.WriteLine(ans);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);

            }
        }



    }
}