// Показать четные числа от 1 до N
Console.WriteLine("Введите число N: ");
string strN = Console.ReadLine();
int num = int.Parse(strN);
int min = 2;
while (min < num)
{
    if (min % 2 == 0) Console.WriteLine($"Четные числа: {min} ");
    min++;
}
