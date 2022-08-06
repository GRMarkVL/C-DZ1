
// Напишите программу, которая на вход принимает
// два числа и выдает,какое число наибольшее, а какое наименьшее
int a, b;

 Console.WriteLine("Введите два числа : ");

a = Convert.ToInt32(Console.ReadLine());

b = Convert.ToInt32(Console.ReadLine());

       if (a > b)

       {

        Console.WriteLine("{0} наибольшее число", a);
        Console.WriteLine("{0} наименьше число", b);

       }

       if (b > a)

       {

        Console.WriteLine("{0} наибольшее число ", b);
        Console.WriteLine("{0} наименьше число ", a);
       }
       
       else 
       
       {
        
        Console.WriteLine($"введенные два числа 1: {a}, 2: {b} равны.");
       }


    Console.ReadLine();