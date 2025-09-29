using System;

namespace RhombusAreaCalculator
{
    class Program
    {
        static void Main()
        {
            // Виведення заголовку програми
            Console.WriteLine("===============================================");
            Console.WriteLine("    Калькулятор площі ромба за діагоналями    ");
            Console.WriteLine("===============================================");
            Console.WriteLine("Формула: S = (l * f) / 2");
            Console.WriteLine("де l та f - діагоналі ромба\n");
            
            double l, f;
            
            // Введення першої діагоналі з перевіркою
            Console.Write("Введіть першу діагональ (l): ");
            while (!double.TryParse(Console.ReadLine(), out l) || l <= 0)
            {
                Console.WriteLine("Помилка! Введіть додатне число.");
                Console.Write("Введіть першу діагональ (l): ");
            }
            
            // Введення другої діагоналі з перевіркою
            Console.Write("Введіть другу діагональ (f): ");
            while (!double.TryParse(Console.ReadLine(), out f) || f <= 0)
            {
                Console.WriteLine("Помилка! Введіть додатне число.");
                Console.Write("Введіть другу діагональ (f): ");
            }
            
            // Розрахунок площі ромба
            double area = (l * f) / 2;
            
            // Виведення результатів
            Console.WriteLine("\n=============== РЕЗУЛЬТАТ ===============");
            Console.WriteLine($"Перша діагональ (l):  {l}");
            Console.WriteLine($"Друга діагональ (f):  {f}");
            Console.WriteLine($"Площа ромба (S):      {area:F2} кв. од.");
            Console.WriteLine("=========================================");
            
            // Додаткова інформація
            Console.WriteLine("\nФормула розрахунку:");
            Console.WriteLine($"S = (l × f) / 2 = ({l} × {f}) / 2 = {area:F2}");
            
            Console.WriteLine("\nНатисніть будь-яку клавішу для завершення...");
            Console.ReadKey();
        }
    }
}