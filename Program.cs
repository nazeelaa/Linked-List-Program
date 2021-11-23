using System;

namespace Day14PracticeProblems
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Linked List Program.");
            LinkedList List = new LinkedList();
            List.Add(70);
            List.Add(30);
            List.Add(56);
            List.Display();
        }
    }
}
