//17. Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка
/* 
Random rand = new Random();
//Тип данных
int x = rand.Next(-10, 11);

int y = rand.Next(-10, 11);
Console.WriteLine($"A {x}, {y}");

if (x>0 && y>0)
{
    Console.WriteLine("1-я четверть");
}
else if (x<0 && y>0)
{
    Console.WriteLine("2-я четверть");
}
else if (x<0 && y<0)
{
    Console.WriteLine("3-я четверть");
}
else if (x>0 && y<0)
{
    Console.WriteLine("4-я четверть");
}
*/

/*void Zadacha18() 
{ Console.WriteLine("Введите номер четверти");
int number = Convert.ToInt32(Console.ReadLine());
if (number == 1) Console.WriteLine("x > 0 И y > 0"); 
else if (number == 2) Console.WriteLine("x < 0 И y < 0"); 
else if (number == 3) Console.WriteLine("x < 0 И y < 0"); 
else if (number == 4) Console.WriteLine("x > 0 И y < 0"); 
else Console.WriteLine("Такой четверти не существует"); }
 Zadacha18(); 
*/
 //Задача 21. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между 
 //ними в 2D пространстве. 

//void Zadacha21()
/*
{ Random rand = new Random();
 double x1 = rand.Next(-10, 10); 
 double y1 = rand.Next(-10, 10); 
 Console.WriteLine($"Координаты точки А = ({x1}, {y1})"); 
 double x2 = rand.Next(-10, 10); 
 double y2 = rand.Next(-10, 10); 
 Console.WriteLine($"Координаты точки B = ({x2}, {y2})"); 
 double dist = 0; dist = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2)); 
 Console.WriteLine($"Расстояние между двумя точками на плоскости равно {Math.Round(dist, 2)}"); 
 }*/
/*
 void Zadacha21() 
 { Console.WriteLine("Введите координаты 1-ой точки"); 
 double x1 = Convert.ToInt32(Console.ReadLine()); 
 double y1 = Convert.ToInt32(Console.ReadLine()); 
 Console.WriteLine("Введите координату 2-ой точки"); 
 double x2 = Convert.ToInt32(Console.ReadLine()); 
 double y2 = Convert.ToInt32(Console.ReadLine()); 
 Console.WriteLine($"Расстояние = {Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2))}");
  } 
  Zadacha21(); 
  
  { /*Задача 21: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.*/ 
  /*Console.WriteLine("|------Задача 21-------|"); 
  Console.Write("Введите координаты первой точки A x1:-> "); 
  int x_1 = Convert.ToInt32(Console.ReadLine()); 
  Console.Write("Введите координаты первой точки A y1:-> "); 
  int y_1 = Convert.ToInt32(Console.ReadLine()); 
  Console.Write("Введите координаты второй точки B x2:-> "); 
  int x_2 = Convert.ToInt32(Console.ReadLine()); 
  Console.Write("Введите координаты второй точки B y2:-> "); 
  int y_2 = Convert.ToInt32(Console.ReadLine()); 
  Console.WriteLine($"Координаты точек A({x_1}, {y_1}) и B({x_2}, {y_2})"); 
  //int result = (x_2 - x_1)^2 + (y_2 - y_1)^2;
   double result = Math.Sqrt(Math.Pow(x_2 - x_1, 2) + Math.Pow(y_2 - y_1, 2)); 
   Console.Write($"Pасстояние между ними в 2D пространстве:-> {result} "); 
*/

// Задача 22
Console.WriteLine("Введите число: "); 
int number = Convert.ToInt32(Console.ReadLine()); 
int i= 0;
while (i <=number)
Console.WriteLine(number*number);