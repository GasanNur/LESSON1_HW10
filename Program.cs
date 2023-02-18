//  Напишите программу, которая принимает на вход трёхзначное число и на выходе
//  показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

int number = ReadInt("Введите трехзначное число: "); // вводим 3-х значное число 
int amount = number.ToString().Length;

if (amount < 3 || amount > 3)  // если число больше 3 или меньше 3-х то ...
{
    Console.WriteLine("Вы ввели не трехзначное число");
}
else
{
    Console.WriteLine(InCenter(number)); 
}

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

 int InCenter(int a)
{
    
    int result = ((a / 10) % 10); // функция для определиения среднего числа из 3-х значного. 
    return result;
}
