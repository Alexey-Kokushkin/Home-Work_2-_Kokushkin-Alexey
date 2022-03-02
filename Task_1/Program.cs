// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
//456 -> 5
//782 -> 8
//918 -> 1

Console.WriteLine("Введите число: ");
String inputnumber = Console.ReadLine();
int number = int.Parse(inputnumber);

int dif(int number)
{
    int dec = number / 10;
    int units = dec % 10;
    return units;
}
int result = dif(number); 
Console.WriteLine(result);
