// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.


int Sumofdigits (int number)
{
    string s1 = number.ToString();
    int l = s1.Length;
    int count = 0;
    int sum = 0;
    for(count = 0; count<l; count ++ )
    {
        sum = sum + (number % 10);
        number = number / 10;
    }
    return sum;
}

int EnterData(string text)
{
    Console.WriteLine(text);
    int number = int.Parse(Console.ReadLine());
    return number;
}
//Решение
//Вводим число
int number = EnterData("Введите число: ");
//Считаем сумму его цифр
int sum = Sumofdigits(number);

//Выводим результат 
Console.WriteLine($"Сумма цифр числа {number} равна {sum} ");
