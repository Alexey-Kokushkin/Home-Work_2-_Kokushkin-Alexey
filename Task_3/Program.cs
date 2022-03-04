// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6

Console.WriteLine("Введите число: ");
String inputnumber = Console.ReadLine();
int size = inputnumber.Length;

if(size < 3)
{
    Console.WriteLine("Третья цифра числа отсутствует ");
}

int[] array = new int[size];
int currentindex = 0;
while (currentindex < size)
{
    array[currentindex] = int.Parse(inputnumber[currentindex].ToString());
    currentindex++;
}
Console.WriteLine(array[2]);


