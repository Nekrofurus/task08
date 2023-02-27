// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N
Console.WriteLine("Уважаемый пользователь введите целое число и мы покажем все чётные числа от 1 до вашего числа");
int numberN = Convert.ToInt32(Console.ReadLine());
for (int i =2; i < numberN; i = i + 2)
{
Console.WriteLine(i);
}

