// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6
// Второй способ решения задачи 13

Console.WriteLine("Введите число:");
string number = Console.ReadLine();
int index = 2;
if(number[0] == '-') index ++;
if(number.Length <= index)
{
    Console.WriteLine($"Нет третьей цифры в числе {number}");
}
else
{
    Console.WriteLine($"Третья цифра {number[index]}");
}
