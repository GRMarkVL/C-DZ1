//Напишите програму , которая принимает на вход
// три числа и выдает максимальное из этих чисел
Console.Write("a: ");
var a = int.Parse(Console.ReadLine());
Console.Write("b: ");
var b = int.Parse(Console.ReadLine());
Console.Write("c: ");
var c = int.Parse(Console.ReadLine());
Console.WriteLine((a > b) ? (a > c) ? a : c : (b > c) ? b : c );
Console.ReadKey();

