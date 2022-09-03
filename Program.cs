//using System;

//int a, b;

//Console.WriteLine("Введите значение а.");
//a = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine("Введите значение b.");
//b = Convert.ToInt32(Console.ReadLine());

//int c = a;

//a = b;
//b = c;

//Console.WriteLine($"a = (a), b = (b)");

using System;

int a, b;
a = Convert.ToInt32(Console.ReadLine());
b = Convert.ToInt32(Console.ReadLine());

a = a - b;
b = a + b;
a = b - a;

Console.WriteLine()

