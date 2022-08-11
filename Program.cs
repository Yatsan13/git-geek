Задачу номер 8 моя никак не осилит :(

/*
Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
if (number % 2 == 0)
{
Console.WriteLine("Число четное");
}
else{
    Console.WriteLine("Число нечетное");
}


Console.WriteLine("Введите первое число");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int numberB = Convert.ToInt32(Console.ReadLine());
if (numberA > numberB)
{
Console.WriteLine(numberA);
}
else {
    Console.WriteLine(numberB);
}
*/

Console.WriteLine("Введите первое число");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int numberB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число");
int numberC = Convert.ToInt32(Console.ReadLine());
int max = numberA;
if (numberA > max) max = numberA;
if (numberB > max) max = numberB;
if (numberC > max) max = numberC;
Console.WriteLine(max);

