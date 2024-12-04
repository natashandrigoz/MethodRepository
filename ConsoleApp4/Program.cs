using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
	/// <summary>
	/// Заполнить одномерный массив с клавиатуры
	/// и вывести его на экран
	/// </summary>
	internal class Program
	{
		static void Main(string[] args)
		{
			int size = GetArraySize(); 
			int[] array = Input(size); 
			Output(array); // Выводим массив на консоль
			Console.Read();
		}
		/// <summary>
		/// Метод получения размера массива
		/// </summary>
		/// <returns>размер массива</returns>
		static int GetArraySize()
		{
			Console.Write("Введите размер массива: ");
			int size;
			while (!int.TryParse(Console.ReadLine(), out size) || size <= 0)
			{
				Console.WriteLine("Неверный ввод. Пожалуйста, введите положительное целое число.");
			}
			return size;
		}
		/// <summary>
		/// Метод заполнения массива с клавиатуры
		/// </summary>
		/// <param name="size">размер</param>
		/// <returns>одн. массив</returns>
		static int[] Input(int size)
		{
			int[] array = new int[size];
			//for (int i = 0; i < size; i++)
			//{
			//	Console.Write($"Введите элемент {i + 1}: ");
			//	while (!int.TryParse(Console.ReadLine(), out array[i]))
			//	{
			//		Console.WriteLine("Неверный ввод. Пожалуйста, введите целое число.");
			//	}
			//}
			for (int i = 0; i < size; i++)
			{
				Console.Write($"array[{i}] = ");
				array[i] = int.Parse(Console.ReadLine());
			}
			return array;
		}
		/// <summary>
		/// Метод вывода массива на консоль
		/// </summary>
		/// <param name="array">массив</param>
		static void Output(int[] array)
		{
			Console.WriteLine("Элементы массива:");
			//foreach (int element in array)
			//{
			//	Console.WriteLine(element);
			//}
			for (int i = 0; i < array.Length; i++)
			{
				Console.WriteLine($"omas[{i}]= {array[i]}");
			}
		}
	}
}

