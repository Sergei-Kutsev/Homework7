using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
			//Создать метод для вычисления объема и площади поверхности куба по длине его ребра.
			Console.WriteLine("Введите длину ребра куба");
			double n = Convert.ToDouble(Console.ReadLine());
			MetodAreaVolume(n);
		}
		static void MetodAreaVolume(double n)
		{
			double S = Math.Pow(n, 2) * 6;
			double V = Math.Pow(n, 3);
			Console.WriteLine("Площадь поверхности куба равна {0:f2}", S);
			Console.WriteLine("Объем куба равен {0:f2}", V);
			Console.ReadKey();
		}
	}
}
