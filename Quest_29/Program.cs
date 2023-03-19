// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран. 
// (числа берете любые)

// Запрос размерности массива
int number(string text)
{
  Console.Write(text);
  return Convert.ToInt32(Console.ReadLine()!);
}
// Функция массива из рандомных цифр
int[] Massiv(int size)
{
  int[] A = new int[size];
  for(int i =0; i < size; i++)
  {
    A[i] = new Random().Next(0, 10);
  }
return A;
}
// Исполнительная часть
int num = number("Введите размерность массива ");
int[] B = Massiv(num);
Console.Write($"[{String.Join("; ",B)}]");

