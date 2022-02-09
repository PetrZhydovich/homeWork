//  Выяснить является ли число чётным
Console.WriteLine("Введите целое число: ");
string numberStr = Console.ReadLine();
 double num = int.Parse(numberStr);
 if (num % 2 == 0) Console.WriteLine($"Число {num} Является четным");
 else
 {
     Console.WriteLine($"Число {num} не является четным");
 }
 
