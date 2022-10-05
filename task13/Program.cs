/*Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/
int number = new Random().Next();
Console.WriteLine(number); 
 
void GetThirdDigit(int number)
{
    if (number >= 100)
    {
        while(number > 999) 
        {
            number = number / 10;         
        }
            Console.WriteLine(number % 10);
        
    }
    else
    {
        Console.WriteLine("Третьей цифры нет");
    }
}

GetThirdDigit(number);













/*
int RandomNumber (int number)
{
    int result = new int();
    result = new Random().Next();
    return result;
}

int result = RandomNumber(number);
Console.WriteLine(result);

string Number(int number)
{
    string noNumber = "";
    if(number < 100)
    {
        noNumber = "третьей цифры нет";
    }
    return noNumber;


new Random().Next();

int number = new Random().Next();

string Number(int number)
{
    string noNumber = "";
    if(number < 100)
    {
        noNumber = "третьей цифры нет";
    }
    return noNumber;
}
Console.WriteLine(number);
string Result = Number(number);
Console.Write(Result);


*/
