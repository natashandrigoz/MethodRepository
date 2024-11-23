using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
	/// <summary>
	/// Найти максимальную величину из двух целых переменных a, b 
	/// с использованием вспомогательных методов
	/// </summary>
	internal class Program
	{
		/// <summary>
		/// Основной метод
		/// (точка входа для исполняемой программы)
		/// </summary>
		/// <param name="args">string[]</param>
		static void Main(string[] args)
		{
			int a = Input("a= ");
			int b = Input("b= ");
			Console.WriteLine($"Максимальная величина из двух чисел {a} и {b} - это {Max(a, b)}");
			Console.Read();
		}
		/// <summary>
		/// Метод ввода исходных целых переменных
		/// </summary>
		/// <param name="message">message</param>
		/// <returns>целое число</returns>
		public static int Input(string message)
		{
			Console.Write(message);
			return int.Parse(Console.ReadLine());
		}
		/// <summary>
		/// Метод сравнения двух целых чисел
		/// </summary>
		/// <param name="value1">первое число</param>
		/// <param name="value2">второе число</param>
		/// <returns>макстмальное число</returns>
		static int Max(int value1, int value2)
		{
			return (value1 > value2) ? value1 : value2;
		}
	}
}
