//Задача 19 Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

//void palindrom()
//{
    //int number = new Random().Next(1, 100000); Для случайных чисел
//    Console.Write("Insert 5-digit number: ");
//    int number = Convert.ToInt32(Console.ReadLine());
//    int num1 = number / 10000 % 10;
//    int num2 = number / 1000 % 10;
//    int rev1 = number / 10 % 10;
//    int rev2 = number % 10;
//    int nul = number / 10000;
//
//    if (nul < 1 || nul > 9)
//    {
//        Console.WriteLine(number + " -> " + "Not 5-digit number");
//    }
//    else if (num1 == rev2 && num2 == rev1)
//    {
//        Console.WriteLine(number + " -> Yes, this is palindrom");
//    }
//    else
//    {
//        Console.WriteLine(number + " -> No, this is not palindrom");
//    }
//}
//for (int i = 0; i < 10; i++)
//{
//    palindrom();
//}

//Задача 21 Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

//int FindQuart(double x, double y, double z)
//{
//int num = 0;

//if(x > 0 && y > 0 && z > 0) num = 1;
//if(x < 0 && y > 0 && z < 0) num = 2;
//if(x < 0 && y < 0 && z < 0) num = 3;
//if(x > 0 && y < 0 && z > 0) num = 4;
//if(x > 0 && y < 0 && z < 0) num = 4;
//if(x < 0 && y > 0 && z > 0) num = 2;
//if(x < 0 && y < 0 && z > 0) num = 3;
//if(x > 0 && y > 0 && z < 0) num = 1;

//return num;
//}

//Console.Write("imput x-coordinate: ");
//double x = Convert.ToDouble(Console.ReadLine());
//Console.Write("imput y-coordinate: ");
//double y = Convert.ToDouble(Console.ReadLine());
//Console.Write("imput z-coordinate: ");
//double z = Convert.ToDouble(Console.ReadLine());

//int quartNum = FindQuart(x, y, z);
//Console.WriteLine($"The point A({x}, {y}, {z}) is in {quartNum} quart");
//Задача 23 Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

//class Program
//{
//    static void Main(string[] args)
//    {
//        Console.Write("Введите кол-во чисел для вывода:");
//       int N = int.Parse(Console.ReadLine());
//
//        Console.WriteLine("Число" + "\t" + "Квадрат");
//        for (int i = 1; i <= N; i++)
//            Console.WriteLine(i + "\t" + i * i);
//
//        Console.ReadLine();
//
//    }
//}

