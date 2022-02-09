//  Даны два числа. Показать большее и меньшее число

Console.WriteLine("Введите первое число:");
int numbreOne = Convert.ToInt32 (Console.ReadLine());
Console.Write("Введите второе число:");
 int numbreTwo = Convert.ToInt32 (Console.ReadLine()); 

if(numbreOne > numbreTwo)
{
    Console.WriteLine("Больше первое число: " + numbreOne +"\n Второе меньше: " + numbreTwo);
}
else
{
    Console.WriteLine("Больше второе число: " + numbreTwo + "\n Первое меньше: " + numbreOne);
}