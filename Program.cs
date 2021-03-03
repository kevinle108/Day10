using System;
using System.Collections.Generic;

namespace Day10
{
    class Program
    {
        static void Main(string[] args)
        {
            var ls = new List<string> { "A", "B", "C" };
            Permutations(ls);

        }

        // Recursive problem #1

        static int Factorial(int n)
        {
            if (n < 0) return -1;
            if (n == 1) return 1;
            return n * Factorial(n - 1);
        }

        // Recursive problem #2

        static int SumOfDigits(int n)
        {
            if (n < 0) return -1;
            if (n < 10) return n;
            return (n % 10) + SumOfDigits(n / 10);
        }

        // Recursive problem #3

        static void ReverseString(string s)
        {
            if (s.Length == 0) return;
            Console.Write(s[^1]);
            ReverseString(s[0..^1]);
            
            
        }

        // Recursive problem #4

        static bool IsPalindrome(string s)
        {
            return false;
        }

        // Recursive problem #5 – Skip for now

        // static bool SortedNodes(Node root)


        // Recursive problem #6

        static bool IsSubsequence(string s1, string s2)
        {
            return false;
        }

        // Recursive problem #7

        static void Subsets(List<string> ls)
        {
            var mustInclude = new List<string>();
            Subsets(ls, mustInclude);
        }
        
        static void Subsets(List<string> ls, List<string> mustInclude)
        {
            if (ls.Count == 0) {
                PrintList(mustInclude);
                return;
            }
            var newList = new List<string>(ls);
            var newMust = new List<string>(mustInclude);
            string s = newList[0];
            newList.RemoveAt(0);
            Subsets(newList, newMust);
            newMust.Add(s);
            Subsets(newList, newMust);
        }

        static void PrintList(List<string> ls)
        {
            Console.Write("{ ");

            foreach (string s in ls)
            {
                Console.Write(s + " ");
            }

            Console.Write("} ");
        }

        // Recursive problem #7

        //static void Subsets(List<string> ls)
        //{
        //    // Your code goes here
        //}

        //// Recursive problem #7

        //static void Subsets(List<string> ls)
        //{
        //    // Your code goes here
        //}

        //// Recursive problem #7

        //static void Subsets(List<string> ls)
        //{
        //    // Your code goes here
        //}

        // Recursive problem #8

        static void Permutations(List<string> ls)
        {
            var starter = new List<string>();
            Permutations(ls, starter);
        }

        static void Permutations(List<string> ls, List<string> starter)
        {
            if (ls.Count == 0)
            {
                PrintList(starter);
                return;
            }

            for (int i = 0; i < ls.Count; i++)
            {
                var newList = new List<string>(ls);
                newList.RemoveAt(i);
                var newStarter = new List<string>(starter);
                newStarter.Add(ls[i]);
                Permutations(newList, newStarter);
            }
        }

        // Recursive problem #9

        static void KSubsets(List<string> ls, int k)
        {
            // Your code goes here
        }

        // Recursive problem #10

        static void KPermutations(List<string> ls, int k)
        {
            // Your code goes here
        }

        // Recursive problem #11

        static void GroupAssignments(List<string> ls, int k)
        {
            // Your code goes here
        }

        // Recursive problem #12

        static void Parentheses(int n)
        {
            // Your code goes here
        }

        // Recursive problem #13

        static void Passwords(int n)
        {
            // Your code goes here
        }

        // Recursive problem #14

        static void MakeSum(int n)
        {
            // Your code goes here
        }


    }
}
