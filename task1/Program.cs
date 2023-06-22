//Напишите программу, которая принимает на вход пятизначное число и проверяет,является ли оно палиндромом.

int ReadInt(string message)
{
    Console.Write(message);
    int inputedNum = Convert.ToInt32(Console.ReadLine());
    return inputedNum;
}
int number = ReadInt("Введите пятизначное целое число ");

if ((number / 10000 == number % 10) && (number / 1000 % 10 == number / 10 % 10))
{
    Console.WriteLine($"{number} является палиндромом");
}
else
{
    Console.WriteLine($"{number} не является палиндромом");
}


// Console.Write("Введите пятизначное число ");
// string inputString = Console.ReadLine();

// void  check_polindrom(string text)
// {
//     int len = inputString.Length;
//     int count = 0;
//     while (count < (len / 2))
//     {
//         if (inputString[count] == inputString[len - count - 1])
//         {
//             count++;
//         }
//         else 
//         {
//          Console.Write("Введенное число не палиндром");
//         }
//         Console.Write("Введенное число палиндром");
   
// }
// check_polindrom(inputString);
