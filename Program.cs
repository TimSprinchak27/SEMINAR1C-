namespace HelloWord
{
class Program
  { 
       // Напишите программу, которая на вход принимает число и выдает его квадрат (число умноженное на само себя)  

       static void Main(string[] args)
      {
          Console.WriteLine("Введите целое число: ");
          // 1. Получаем число 
          int numbers = Convert.ToInt32(Console.ReadLine());
          // 2. Умножаем и записываем в отдельную переменную
          int square = numbers * numbers;
          // Или 3. Получаем квадрат в переменной  number
          numbers*= numbers;

          // 4. Вывод результата 
          Console.WriteLine($"Квадрат числа: {square}");

      }

  }

}

