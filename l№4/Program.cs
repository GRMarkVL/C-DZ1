//Напишите програму , которая принимает на вход
// три числа и выдает максимальное из этих чисел

int a, b, c;

 Console.WriteLine("Введите два числа : ");

a = Convert.ToInt32(Console.ReadLine());

b = Convert.ToInt32(Console.ReadLine());

c = Convert.ToInt32(Console.ReadLine());
    {
        int max=a;
        if (a > b) max=a;
            if (b > max) max=b;
                if(c > max) max=c;
                    if ((max==a)&&(max==b)&&(max==c)) Console.WriteLine("Все три числа равны!");
                        else Console.WriteLine($"Максимальное число из трех чисел: {max}");
    }                    