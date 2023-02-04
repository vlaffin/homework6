//Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
//   void chetnie()
//   {
//   System.Console.WriteLine("Здравствуйте! это вторая программа, спасибо за участие в тестировании, и оставте пожалуйста отзыв");
//   Console.WriteLine("Введите массив чисел через пробел, а программа скажет сколько чисел > 0 вы ввели (можно и дробные)");
//   int count = 0;
//   string input = Console.ReadLine()!;
//   string[] numberStrings = input.Split(" ");
//   double[] numbers = new double [numberStrings.Length];

//   for ( int i = 0; i < numbers.Length; i++)
//   {
//       numbers[i] = double.Parse(numberStrings[i]);
//       if(numbers[i] > 0)
//       count++;
//   }
//   System.Console.WriteLine($"[{String.Join(",", numbers)}]");
//   System.Console.WriteLine($"из них положительных {count}");
//   }
//  chetnie();



// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// void IntersectionPoint()
// {
// System.Console.WriteLine("Здравствуйте! это первая программа, спасибо за участие в тестировании, и оставте пожалуйста отзыв)");
// System.Console.WriteLine("Введите числа, а программа найдёт точку пересечения двух прямых: ");
// System.Console.WriteLine("Введите число k1: ");
// double k1 = double.Parse(Console.ReadLine());
// System.Console.WriteLine("Введите число b1: ");
// double b1 = double.Parse(Console.ReadLine());
// System.Console.WriteLine("Введите число k2: ");
// double k2 = double.Parse(Console.ReadLine());
// System.Console.WriteLine("Введите число b2: ");
// double b2 = double.Parse(Console.ReadLine());
// double x = 0;
// double y = 0;
// x = (b2 - b1) / (k1 - k2);
// y = k1 * x + b1;
// y = k2 * x + b2;
// Console.Write($"точка пересечения двух прямых: {x};");
// Console.Write(y);
// }
// IntersectionPoint();