/*//Задача №1 вывести квадрат числа
int number1 = 5;
int number2;
number2= 6;

int result = (number1 * number2);

Console.WriteLine($"{number1}*{number2}={result}" );
*/

// Ветвление

/*int number1 = 15;

if(number1 > 10)
{
    Console.WriteLine("число больше 10");

}
else
Console.WriteLine("число меньше 10");
*/

/*
Console.WriteLine("Введите первое число");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int b = Convert.ToInt32(Console.ReadLine());

if (a == b * b)
Console.WriteLine("Первое число является квадратом второго");
else
Console.WriteLine("Первое число НЕ является квадратом второго");
*/

/* День недели по числу
{Console.WriteLine("Введите число");
int a = Convert.ToInt32(Console.ReadLine());
if(a == 1)
{
    Console.WriteLine("Понедельник");
}

else if(a == 2)
{
    Console.WriteLine("Вторник");
}
else if(a == 3)
{
    Console.WriteLine("Среда");
}
else if(a == 4)
{
    Console.WriteLine("Четверг");
}
else if(a == 5)
{
    Console.WriteLine("Пятница");
}
else if(a == 6)
{
    Console.WriteLine("Суббота");
}
else if(a == 7)
{
    Console.WriteLine("Воскресенье");
}
else 
{
    Console.WriteLine("неверное число");
}

}
*/


//Возведение числа в квадрат
/*
{Console.WriteLine("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());
PrintPower(number);

void PrintPower(int number2)
{
    Console.WriteLine($"{number} * {number} = {number * number}");
}
}
*/

// Вывод целых чисел (от -N до N) 
/*
{Console.WriteLine("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());

number = Math.Abs(number);
int count = -number;

while(count <= number)
{
Console.Write(count+" ");
count++;
}
Console.WriteLine();
}
*/

/*
Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());

int i = -num;
int max = num;
if(num<0)
{
i = num;
max = -num;
}

while (i < max)
{
Console.Write(i+",");
i += 1;
}
while (i == max)
{Console.WriteLine(i+".");
i += 1;
Console.WriteLine();
}
*/

/*
Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());

int i = - Math.Abs(num);
int max = Math.Abs(num);
Console.WriteLine("");
while (i <= max)
{
Console.Write($" {i} ");
i += 1;
}
*/

//ДЗ Задача 2. Приниаются два числа и выводит какое число больше
/*
Console.WriteLine("Введите первое число");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int num2 = Convert.ToInt32(Console.ReadLine());

if(num1 >num2)
{
    Console.Write($" {num2} < {num1} ");
}
else
{
    Console.Write($" {num1} < {num2} ");
}
*/

//ДЗ Задача 4. Принимается три числа, выдается наибольшее.
/*
Console.WriteLine("Введите первое число");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число");
int num3 = Convert.ToInt32(Console.ReadLine());

if(num1 >num2)
{
    Console.Write($" < {num1} ");
}
else if(num2 >num3)
{
    Console.Write($" < {num2} ");
}
else 
{
Console.Write($" < {num3} ");
}
*/
// ДЗ Задача 6 Вводится число и сообщается четное оно или нет
/*
Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());
if (num %2 ==0)
{
    Console.Write($" {num} четное ");
}
else 
{
Console.WriteLine($" {num} нечетное");
}
*/

//ДЗ Задача 8 Вводится число (N), а программа выдает все четные числа от 1 до (N)


Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());

for( int i=1; i <=num; i++)
{if(i %2==0)

Console.WriteLine($" {i} ");}
