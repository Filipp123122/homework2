/*Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1
*/

int number = new Random().Next(100,1000);

int ShowSecondDigitFromNumber(int number)

{
    int twoDigits = number / 10;
    int secondDigit = twoDigits % 10;
    return(secondDigit);
} 
Console.WriteLine(number);
int result = ShowSecondDigitFromNumber(number);
Console.WriteLine(result);