// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную 
//степень B. (Задачи, решенные через Math.Pow, не будут считаться правильными, так как задача 
//стоит в том, чтобы написать цикл)

// 1. Метод для введения чисел.
int Number(string text)
{
  Console.Write(text);
  return int.Parse(Console.ReadLine()!);
}

// 2. Метод для возведения числа a в степень числа b.

int mathpow(int a, int b)
{
  int result = 1;
  for(int i = 1; i < b + 1; i++)
  {
    result = result * a;
  }
return result;
}

int A = Number("Введите число A ");
int B = Number("Введите число B ");

int R = mathpow(A, B);
Console.WriteLine($"A в степени B равно {R}");