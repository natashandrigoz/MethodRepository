using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
	/// <summary>
	/// Найти s=max(a, b) + max(c, d), используя 
	/// вспомогательную функцию (метод)
	/// </summary>
	internal class Program
	{
		static void Main(string[] args)
		{
			int a = Input("a= ");
			int b = Input("b= ");
			int c = Input("c= ");
			int d = Input("d= ");
			int rez = Max(a, b) + Max(c, d);
			Output(rez);
			Console.Read();
		}
		public static int Input(string message)
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
					Console.WriteLine("Неверный ввод. Пожалуйста, введите число.");
				}
			}
		}
		static int Max(int value1, int value2)
		{
			return (value1 > value2) ? value1 : value2;
		}
		static void Output(double maxNumber)
		{
			Console.WriteLine($"Максимальное число: {maxNumber}");
		}
	}
}
