// Задача 2 
/*
Console.Write("Напишите первое число для сравнения ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Напишите второе число для сравнения ");
int num2 = Convert.ToInt32(Console.ReadLine());

if(num1 > num2)
    Console.Write("Максимамальное число " + num1);
else
    Console.Write("Максимальное число " + num2);
*/

//Задача 4

Console.Write("Напишите первое число для сравнения ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Напишите второе число для сравнения ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Напишите третье число для сравнения ");
int num3 = Convert.ToInt32(Console.ReadLine());
int max = num1;

if(max < num1)
    max = num1;
if(max < num2)
    max = num2;
if(max < num3)
    max = num3;

Console.Write("Максимальное число " + max);
