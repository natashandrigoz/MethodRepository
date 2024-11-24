using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
	/// <summary>
	/// Массив предназначен для хранения значений ростов двенадцати человек. 
	/// С помощью датчика случайных чисел заполнить массив целыми значениями, 
	/// лежащими в диапазоне от 163 до 190 включительно. 
	/// Вывести значения элементов с использованием цикла for. 
	/// Найти средний рост
	/// </summary>
	internal class Program
	{
		static void Main(string[] args)
		{
			int[] omas = Input();
			Output(omas);
			Console.WriteLine($"Средний рост = {Average(omas)}");
			Console.Read();
		}
		static int[] Input()
		{
			int[] omas = new int[12];
			Random random = new Random();
			for (int i = 0; i < omas.Length; i++)
			{
				omas[i] = random.Next(163, 190);
			}
			return omas;
		}
		static void Output(int[] omas)
		{
			for (int i = 0; i < omas.Length; i++)
			{
				Console.WriteLine($"omas[{i}]= {omas[i]}");
			}
		}
		static int Average(int[] omas)
		{
			int sum = 0;
			for (int i = 0; i < omas.Length; i++)
			{
				sum += omas[i];
			}
			return sum / omas.Length;
		}

	}
}
