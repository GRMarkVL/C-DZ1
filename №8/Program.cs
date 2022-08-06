// напишите программу , которая на вход принимает число n,
//а на выходе показывает все чётные числа от 1 до n
Console.Write("введите число n: ");
        int n = int.Parse(Console.ReadLine());
        for (int i = 1; i <= n; i++)
        {
            if (i % 2 == 0) 
            {
                Console.Write(i + " ");
            }
        }
        Console.ReadKey();