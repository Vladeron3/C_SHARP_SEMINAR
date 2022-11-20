/*void Zadacha19()
{
    //Напишите программу, которая принимает на вход пятизначное (12345)число и проверяет, является ли оно палиндромом.

    Console.WriteLine("Введите пятизначное число");
    int number = Convert.ToInt32(Console.ReadLine());
    int a1 = number / 10000 % 10;
    int a2 = number / 1000 % 10;
    int a3 = number / 100 % 10;
    int a4 = number / 10 % 10;
    int a5 = number % 10;

    if (number > 9999 && number < 100000)
    {
        if (a1 == a5 && a2 == a4)
        {
            Console.WriteLine("Число является полиндромом");
        }

        else
            Console.WriteLine("Число не является полиндромом");
    }
    else

        Console.WriteLine("Неверный ввод");
}
//Zadacha19();
*/
void Zadacha23()
//Задача 23. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
{
    Console.WriteLine("Введите число");
    int number = Convert.ToInt32(Console.ReadLine());
    for (int i = 1; i <= number; i++)

        Console.WriteLine($"{i}{^3}= {i * i * i}");
}

//Zadacha23();