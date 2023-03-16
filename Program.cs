Console.Write("Введите положительное число M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите положительное число N: ");
int n = Convert.ToInt32(Console.ReadLine());
if (m < 0 | n < 0)
{
  Console.WriteLine("Введены отрицательные значения! ");
  return;
}
/// <summary>
/// Метод, который вычисляет функцию Аккермана
/// </summary>
/// <param name="number1">Первое положительное число для расчета</param>
/// <param name="number2">Второе положительное число для расчета</param>
/// <returns>Значение функции</returns>
int AckermanFunction (int number1, int number2)
{
  if (number1 == 0) return (number2 + 1);
  else if (number2 == 0) return (AckermanFunction(number1 - 1, 1));
  else return (AckermanFunction(number1 - 1, AckermanFunction(number1, number2 - 1)));
}
Console.WriteLine($"А({m}, {n}) = {AckermanFunction(m, n)}");
