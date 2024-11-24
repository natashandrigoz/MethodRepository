using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
	internal class Program
	{
		/// <summary>
		/// Основной метод
		/// </summary>
		/// <param name="args">string[]</param>
		static void Main(string[] args)
		{
			// Ввод числа
			int number = GetInput("Введите целое число: ");
			// Вывод делителей числа
			Console.WriteLine($"Делители числа {number}:");
			Divisors(number);
			Console.Read();
		}
		/// <summary>
		/// Метод для ввода целого числа
		/// </summary>
		/// <param name="message">Введите целое число:</param>
		/// <returns>целое число</returns>
		static int GetInput(string message)
		{
			Console.Write(message);
			while (true)
			{
				try
				{
					return Convert.ToInt32(Console.ReadLine());
				}
				catch (FormatException)
				{
					Console.WriteLine("Неверный ввод. Пожалуйста, введите целое число.");
				}
			}
		}
		/// <summary>
		/// Статический метод для вывода делителей числа
		/// </summary>
		/// <param name="n">натуральное число</param>
		static void Divisors(int n)
		{
			for (int i = 1; i <= n; i++)
			{
				if (n % i == 0)
				{
					Console.WriteLine(i);
				}
			}
		}
	}
}
