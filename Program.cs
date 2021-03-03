using System;
using System.Collections.Generic;

namespace Day10
{
    class Program
    {
        static void Main(string[] args)
        {
            //var ls = new List<string> { "A", "B", "C" };
            //Permutations(ls);
            //Console.WriteLine();
            //Console.WriteLine(Factorial(1));
            //Console.WriteLine(Factorial(0));
            //Console.WriteLine(Factorial(-1));
            //Console.WriteLine(Factorial(9));

            Console.WriteLine();

            Console.WriteLine(IsSubsequence("asd", "atysfgfhvd"));




        }

        // Recursive problem #1

        static int Factorial(int n)
        {
            if (n == 1 || n == 0) return 1;
            else if (n < 0) return -1;
            else return n * Factorial(n - 1);
        }

        // Recursive problem #2

        static int SumOfDigits(int n)
        {
            if (n <= 0) return 0;
            else return n + SumOfDigits(n - 1);
        }

        // Recursive problem #3

        static void ReverseString(string s)
        {
            if (s.Length == 1) Console.Write(s);
            else
            {
                Console.Write(s[^1]);
                ReverseString(s[..^1]);
            }
        }

        // Recursive problem #4

        static bool IsPalindrome(string s)
        {
            if (s.Length <= 1) return true;
            else
            {
                if (s[0] != s[^1]) return false;
                return IsPalindrome(s[1..^1]);
            }
        }

        // Recursive problem #5 – Skip for now

        // static bool SortedNodes(Node root)


        // Recursive problem #6

        static bool IsSubsequence(string s1, string s2)
        {
            if (s1.Length == 0 || s2.Length == 0) return false;
            if (s2.Contains(s1)) return true;
            else
            {
                int index = s2.IndexOf(s2[1]);
                if (index == -1) return false;
                return IsSubsequence(s1[1..], s2[index..]);
            }
            
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
