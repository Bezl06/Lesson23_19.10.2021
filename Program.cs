using System;
using System.Collections.Generic;
using System.Linq;

namespace MyApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            System.Console.Write("Введите число : ");
            int.TryParse(Console.ReadLine(), out int num);
            foreach (var x in GetReverseNums(num))
                System.Console.Write($"[{x}] ");
            int[] resArr = GetNumsInfo(new int[] { 2, 4, 6, 8, 12, -10, -8, -6, -14 });
            System.Console.WriteLine($"\n\nРезультат массива : {resArr[0]} , {resArr[1]}");
            System.Console.WriteLine("\nРезультат сортировки");
            foreach (var x in SortStings(new string[] { "One", "Two", "Three", "Four", "Eleven" }))
                System.Console.WriteLine(x);
            System.Console.WriteLine($"\nУникальное число : {GetSpecialNum(new int[] { 4, 4, 4, 4, 6, 4, 4, 4 })}");
        }
        public static int[] GetReverseNums(int num) => num.ToString().Reverse().Select(c => (int)c - 48).ToArray();
        public static int[] GetNumsInfo(int[] arr) => new int[] { arr.Count(x => x > 0), arr.Where(x => x < 0).Sum() };
        public static string[] SortStings(string[] arr) => arr.OrderBy(x => x.Length).ToArray();
        public static int GetSpecialNum(int[] arr) => arr.GroupBy(x => x).First(x => x.Count() == 1).Key;
    }
}