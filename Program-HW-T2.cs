// Напишите программу, которая принимает на вход цифру, обозначающую день недели и проверяет является ли этот день выходным.
Console.WriteLine("Введите цифру от 1 до 7");
int Number=Convert.ToInt32(Console.ReadLine());
if (Number==6 || Number==7)
{
    Console.WriteLine("Это выходной день");
}
else
{
    Console.WriteLine("Это будний день");
}