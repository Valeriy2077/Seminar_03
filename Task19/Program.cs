// Задача 19

// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет

// 12821 -> да

// 23432 -> да

System.Console.WriteLine("Введите число");

string? text = Console.ReadLine();

void CheckingNumber(string num)

{
    if (num[0]==num[4] || num[1]==num[3]){

    Console.WriteLine($"Ваше число: {num} - Палиндром");

  }

  else Console.WriteLine($"Ваше число: {num} - Не палиндром");
    }

    if (text!.Length == 5)
    {

  CheckingNumber(text);

    }

else Console.WriteLine("Введено не правильное число");