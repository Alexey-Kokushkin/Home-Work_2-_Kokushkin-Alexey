// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
//6 -> да 
//7 -> да 
//1 -> нет

Console.WriteLine("Введите цифру, обозначающую день недели: ");
String inputnumber = Console.ReadLine();
int number = int.Parse(inputnumber);

String[] array = new string[] {"Monday","Tuesday","Wednesday","Thursday","Friday","Saturday","Sunday"};
//Console.WriteLine(array[0]);
if (number == 6) 
{
    Console.WriteLine("Выходной день  " + array[5]);
}

if (number == 7) 
{
    Console.WriteLine("Выходной день  " + " " + array[6]);
}    
if (number < 6) 
{
    Console.WriteLine("Рабочий день ");
}