// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе
// Метод для запроса числа у пользователя
string number(string text)
{
  Console.Write(text);
  return Console.ReadLine()!;
}
// Метод нахождения суммы цифр запрошенного числа
int Sum(string text)
{
  int result = 0;
  for(int i = 0; i < text.Length; i++)
  {
    result = result + (int)Char.GetNumericValue(text[i])!;
  }
return result;
}
// Исполнительная часть
string num = number("Введите число ");
int S = Sum(num);
Console.Write($"Сумма всех цифр числа равна {S}");