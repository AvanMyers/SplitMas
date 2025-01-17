﻿using System;

namespace Split
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char splitElement = ' ';
            string text = "Дана строка с текстом, используя метод строки String.Split()" +
                " получить массив слов, которые разделены пробелом в тексте и вывести массив, каждое слово с новой строки.";
            string[] subs = text.Split(splitElement);

            foreach (string wrod in subs)
                Console.WriteLine(wrod);

            Console.ReadKey();
        }
    }
}
