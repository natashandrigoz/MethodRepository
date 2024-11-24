using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
	/// <summary>
	/// Определить статический метод int Seconds (int h, int m, int s), 
	/// который принимает три целых аргумента (часы h, минуты m и секунды s) и 
	/// возвращает количество секунд, прошедших с начала дня. 
	/// Используя этот метод, вычислить количество секунд, прошедших с начала дня при:
	/// а) 0 ч 40 мин 20 с;
	/// б) 3 ч 10 мин 50 с.
	/// </summary>
	internal class Program
	{
		/// <summary>
		/// Основной метод
		/// </summary>
		/// <param name="args">string[]</param>
		static void Main(string[] args)
		{
			// Ввод часов, минут и секунд
			int hours = Input("Введите количество часов: ");
			int minutes = Input("Введите количество минут: ");
			int seconds = Input("Введите количество секунд: ");
			// Вычисление общего количества секунд
			int totalSeconds =Seconds(hours, minutes, seconds);
			// Вывод результата
			Output(totalSeconds);
			Console.Read();
		}
		/// <summary>
		/// Метод для ввода целого числа
		/// </summary>
		/// <param name="message">комментарий</param>
		/// <returns>число</returns>
		static int Input(string message)
		{
			Console.Write(message);
			return int.Parse(Console.ReadLine());
		}
		/// <summary>
		/// Статический метод для преобразования часов, минут и секунд в секунды
		/// </summary>
		/// <param name="h">часы</param>
		/// <param name="m">минуты</param>
		/// <param name="s">секунды</param>
		/// <returns>общее кол-во секунд</returns>
		static int Seconds(int h,int m,int s)
		{
			return h*3600+ m*60 + s;
		}
		/// <summary>
		/// Метод для вывода результата
		/// </summary>
		/// <param name="totalSeconds">общее кол-во секунд</param>
		static void Output(int totalSeconds)
		{
			Console.WriteLine($"Общее количество секунд с начала дня: {totalSeconds}");
		}
	}
}
