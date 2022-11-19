//Задача  Выводится наибольшая цифра случайного числа
/*
Console.WriteLine("Задача 9");
Random rand = new Random();
int number;
number = rand.Next(10, 50);
Console.WriteLine("Случайное число: " + number);
int tens = (number /10);
int ones = (number %10);

if( tens > ones) 
Console.WriteLine("Наибольшее число: " + tens);
else
{
    Console.WriteLine("Наибольшее число:" + ones);
}
*/
//(Задача 9 решение 2)

/*
{Console.WriteLine("Задача 9");
int number = GenerateNumber();

int GenerateNumber()
{
    return new Random().Next(10, 100);
}

int MaxDigit(int nummber)
{
    int tens = number / 10;
    int ones = number % 10;

    if (tens > ones)
        return (tens);
    else
    {
        return (ones);
    }
}
Console.WriteLine("Случайное число:" + number);
Console.WriteLine("Наибольшее число " + MaxDigit(number));
}
*/




//Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.

/*
Console.WriteLine("Задача 11");
Random rand = new Random();
int number = rand.Next(100, 1000);
Console.WriteLine("Случайное число: " + number);
int a = (number /100);
int b = (number %10);
Console.WriteLine($"{a}{b}");
*/
/*
Random rand = new Random();
int num = rand.Next(100, 1000);
Console.WriteLine("Случайное число: " + num);
//получение разрядов сотен и единиц
int a = num / 100;
int b = num % 10;
//новое число
int result = a * 10 + b;
//вывод нового числа
Console.WriteLine("Новое число, без второй цифры: " + result);
*/
/*
Random rand = new Random();
int num = rand.Next(100, 1000);
Console.WriteLine("Случайное число: " + num);
Console.WriteLine("Новое число: " + (num/100 * 10 + num % 10));
*/




//12. Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. Если число 2 не кратно числу 1, то программа выводит остаток от деления.
/*
Console.WriteLine("Введите первое число");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int num2 = Convert.ToInt32(Console.ReadLine());
int result = num1 % num2;
if (num1 % num2 * 10 == 0)
    Console.WriteLine("Кратно");
else
    Console.WriteLine("не кратно: отстаток " + result);
*/



//14. Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.

/*Console.WriteLine("Вводим число: ");
int number = Convert.ToInt32(Console.ReadLine());


if (number % 7 == 0 & number % 23 == 0)
{
Console.WriteLine("Введенное число кратно числам 7 и 23");
}
else
{
Console.WriteLine("Введенное число не кратно числам 7 и 23");
}*/

/*
Console.Write("Введите целое число: ");
int num = Convert.ToInt32(Console.ReadLine());
if (num % 7 == 0 && num % 23 == 0)
{
Console.WriteLine($"Число {num} кратно 7 и 23" + "\nОстаток равен 0");
Console.WriteLine("Результат деления на 7: " + num / 7 + "\nРезультат деления на 23: " + num / 23);
}
else if (num % 7 == 0)
{
Console.WriteLine($"Число {num} не кратно 23, но кратно 7");
}
else if (num % 23 == 0)
{
Console.WriteLine($"Число {num} не кратно 7, но кратно 23");
}
*/


//16. Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.{
/*
Console.WriteLine("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());

if (number1 * number1 == number2 | number2 * number2 == number1)
{
Console.WriteLine("число является квадратом другого");
}
else
{
Console.WriteLine("число не является квадратом другого");
}
*/


//ДОМАШНЕЕ ЗАДАНИЕ

//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
/*
  Random rand = new Random();
int num = rand.Next(100, 1000);
Console.WriteLine("Случайное число: " + num);

int a = num / 10;


int result = a % 10 ;

Console.WriteLine("Вторая цифра числа: " + result);      
*/

//Задача 13: Напишите программу,которая с помощью деления выводит третью цифру заданного числа или сообщает, что третьей цифры нет
/*
    Random rand = new Random();
    int num = rand.Next(1, 10000);

    Console.WriteLine("Случайное число: " + num);
    if (num > 99)
    {
        while (num > 1000)
        {
            num = num / 10;
        }
        {
            Console.WriteLine("Третья цифра :" + num % 10);
        }
    }
    else
    {
        Console.WriteLine("В числе нет третьей цифры");
    }
*/



/*//Задача 15. Напишите задачу, которая принимает на вход цифру ободначающую день недели, и проверяет, является ли этот день выходным.

Random rand = new Random();
int num = rand.Next(1, 8);
Console.Write("День недели: " + num);
if(num <= 5)
Console.WriteLine(" -рабочий");
else 
Console.WriteLine("-выходной");
*/