//  Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B (без использования Math.Pow)


int Exponentiation (int a, int b)
{
    int result = 1;
    int count = 0;
    for(count=0; count<b;count++)
    {
        result = result*a;
    }
    return result;
}



int EnterData(string text)
{
    Console.WriteLine(text);
    int number = int.Parse(Console.ReadLine());
    return number;
}

//Принимаем на вход два числа
int a = EnterData("Введите число а: ");
int b = EnterData("Введите число b: ");
// Воводим число x в степень y
int result = Exponentiation(a,b);
// Выводим результат
Console.WriteLine($"число {a} в степени {b} равно {result}");