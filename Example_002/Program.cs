//Найти максимальное из трех чисел
int numbreOne = new Random().Next(1,99);
Console.WriteLine("Перовое число: " + numbreOne);

int numbreTwo = new Random().Next(1,99);
Console.WriteLine("Второе число: " + numbreTwo);

int numbreThree = new Random().Next(1,99);
Console.WriteLine("Третье число: " + numbreThree);

int maxNumber = numbreOne;

if (maxNumber < numbreTwo) maxNumber = numbreTwo;
if (maxNumber < numbreThree) maxNumber = numbreThree;
Console.WriteLine("Максимальное из трёх чисел: " + maxNumber );