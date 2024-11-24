using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
	/// <summary>
	/// Найти максимальную величину их трех целых переменных a, b, c 
	/// с использованием вспомогательных методов
	/// </summary>
	internal class Program
	{
		/// <summary>
		/// Основной метод
		/// </summary>
		/// <param name="args">string[]</param>
		static void Main(string[] args)
		{
			int a = Input("a= ");
			int b = Input("b= ");
			int c = Input("c= ");
			Console.WriteLine($"Максимальное число из трех чисел {a},{b},{c} - {Max(Max(a, b), c)}");
			Console.ReadKey();
		}
		/// <summary>
		/// Метод ввода целой переменной
		/// </summary>
		/// <param name="message">message</param>
		/// <returns>целое число</returns>
		public static int Input(string message)
		{
			Console.Write(message);
			return int.Parse(Console.ReadLine());
		}
		/// <summary>
		/// Метод нахождения максимального из двух чисел
		/// </summary>
		/// <param name="value1">первое число</param>
		/// <param name="value2">второе число</param>
		/// <returns>максимальное число</returns>
		static int Max(int value1, int value2)
		{
			return (value1 > value2) ? value1 : value2;
		}
	}
}
