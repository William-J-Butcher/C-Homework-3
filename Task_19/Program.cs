// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int reverseNumber = 0;
int temp = number;  // временная переменная

while(temp != 0) // получаем реверс введенного числа
{   
    int remainder = temp % 10;
    reverseNumber = reverseNumber * 10 + remainder;
    temp /= 10;
    // Отображение процесса перебора введенного числа в терминале
    // Console.WriteLine($"{reverseNumber} - реверс введенного числа ");
    // Console.WriteLine($"{temp} - введенное число");
}

if(number == reverseNumber) // сравниваем введенное число с реверсом введенного числа
{
    Console.WriteLine("Число полиндром.");
} 
else
{
    Console.WriteLine("Число не является полиндромом.");
}