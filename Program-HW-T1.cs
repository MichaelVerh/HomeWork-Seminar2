// Написать программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет. 
Console.WriteLine("Введите число");
string Number=Console.ReadLine();
if (Number.Length>2)
{
    Console.WriteLine($"Третья цифра числа {Number} - это {Number[2]}");
}
else
{
    Console.WriteLine($"В числе {Number} менее трех цифр");
}