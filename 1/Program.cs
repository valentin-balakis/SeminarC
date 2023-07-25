/* ОБЪЯВЛЕНИЕ ПЕРЕМЕННЫХ

int intNumber = 25;  // Целые числа
double doubleNumber = 12.12;  // дробные числа
string text = "some text";  // от 0 до много символов, включая текст ("25"- строка; 25- число)
bool logicVar = true;  // true/false
*/

/* ВЫВОД ПЕРЕМЕННЫХ НА ЭКРАН

int num1 = 5;
int num2 = 10;
Console.WriteLine("My namber are " + num1 + " and " + num2 + " and it is good!");
Console.WriteLine($"My namber are {num1} and {num2} and it is good!");  //упрощенный вариант записи
*/

/* ВВОД И ВЫВОД ДАННЫХ
Console.Write("Input a number: ");   //ввод дынных пользователем
int num = Convert.ToInt32(Console.ReadLine());  //преобразование строки в число, с присвоением в переменную int
Console.WriteLine("Your number is " + num); //вывод данных 
*/

// Task 1. Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго числа.
/*
Console.Write("Input a first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());

int quad2 = num2 * num2;

if (num1 == quad2) // == оператор сравнения
{
    Console.WriteLine($"{num2} - является квадратом числа {num1}");
}
else
{
    Console.WriteLine($"{num2} - не является квадратом числа {num1}");
}
*/

// Task 2. Напишите программу, которая на вход принимает положительное число (N), а на выходе показывает все целые числа в промежутке от -N до N
/*
Console.Write("Input a number: ");
int num = Convert.ToInt32(Console.ReadLine());

int current = -num;

while(current <= num)
{
    Console.Write(current + " "); //вывод данных с пробелом
    current++;
}
*/

