// Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.
//456 -> 46
//782 -> 72
//918 -> 98

int number = new Random().Next(100,999);
Console.WriteLine(number);
int div1(int number1)
{
    int hundred = number / 100;
    return hundred;
}

int div3(int number3)
{
    int units = number%10;
    return units;
}
int numberindex1 = div1(number);
int numberindex3 = div3(number);


Console.Write(numberindex1);
Console.Write(numberindex3);

