// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом
Console.WriteLine("Введите пятизначное число: ");
int number=Convert.ToInt32(Console.ReadLine());
int number1=number%10;
Console.WriteLine(number1);
int number2=number%100/10;
Console.WriteLine(number2);
int number3=number%1000/100;
Console.WriteLine(number3);
int number4=number/1000%10;
Console.WriteLine(number4);
int number5=number/1000/10;
Console.WriteLine(number5);
if (number5==number1|| number2==number4)
{
    Console.WriteLine("Число является палиандромом");
}
else
{
    Console.WriteLine("Число  не является палиандромом");
}