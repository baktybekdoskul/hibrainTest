using System;

using static System.Math;

namespace Interview

{

	public class Analysis

	{
		//Первый рандом генератор генерирует случайную числу в между {-1;1}
		// потому что random.NextDouble() сгенерирует число между {0.0;0.999999999977}
		//(random.NextDouble() - 0.5)---> {-0.5;0.499999997}
		// ((random.NextDouble() - 0.5)*2)---> {-1.0;0.9999994}
		//метод Round(double) возвращает целое ближайшее число
		// Round(random.NextDouble() - 0.5)*2)--->Round({-1.0;0.9999994}) ---> {-1;1} 
		// метод GetRandomNumber1() возвращает интежер -1 или 0 или 1
		public double GetRandomNumber1()

		{

			Random random = new Random();

			return Round((random.NextDouble() - 0.5) * 2);

		}
		//Второй рандом генератор генерирует случайную числу в между {-1;1}
		/ потому что random.NextDouble() сгенерирует число между {0.0;0.999999999977}
		//(random.NextDouble() - 0.5)---> {-0.5;0.499999997}
		// ((random.NextDouble() - 0.5)*2.99)---> {-1.495;1.495}
		//метод Round(double) возвращает целое ближайшее число
		// Round(random.NextDouble() - 0.5)*2)--->Round({-1.495;1.497}) ---> {-1;1} 
		// метод GetRandomNumber1() возвращает интежер -1 или 0 или 1
		public double GetRandomNumber2()

		{
			Random random = new Random();

			return Round((random.NextDouble() - 0.5) * 2.99);

		}

	}

}