// Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.
//456 -> 46
//782 -> 72
//918 -> 98

int number = new Random().Next(100,999);
Console.WriteLine(number);
int dif(int number)
{
    int hundred = number / 100;
    int dec = number / 10;
    int units = dec % 10;
    return hundred;
    return dec;
    return units;
}
int result = dif(number);
//int hundred = number / 100;
//int dec = number/10;
//int units = number%10;

//result = dec
Console.WriteLine(result);
