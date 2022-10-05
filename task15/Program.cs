/*Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет
*/

int number = new Random().Next(1,8);

string weekend(int number)
{
    string Weekend = "";
    if(number == 6 || number == 7)
    {
        Weekend = "да";
    }
    else
    {
        Weekend = "нет";
    }
    return Weekend;    
}
Console.WriteLine(number);
string result = weekend(number);
Console.WriteLine(result);

