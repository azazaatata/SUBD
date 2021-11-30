using System;
using System.Threading.Channels;

namespace SUBD
{
	class Program
	{
		static double Prop()//определение коэф по пропущенным парам
		{
			Console.WriteLine("Сколько пропустил пар(оценить от 1 до 10)");
			int ch = Convert.ToInt32(Console.ReadLine());
			double ret = -1;
			if (ch > 0 && ch < 11)
				ret = ch / 10;

			return ret;
		}

		static double TimeCh()//определение коэф по времени пары
		{
			Console.WriteLine("Какой по счету идет пара?");
			int ch = Convert.ToInt32(Console.ReadLine());
			double ret = -1;
			switch (ch)
			{
				case 1:
					ret = 0.1;
					break;
				case 2:
					ret = 0.05;
					break;
				case 3:
					ret = 0.4;
					break;
				case 4:
					ret = 0.8;
					break;
				case 5:
					ret = 0.75;
					break;
				case 6:
					ret = 0.6;
					break;
				default:
					Console.WriteLine("Ошибка");
					break;
			}
			return ret;
		}

		static double LikeCh()//определение коэф того как нравится дисциплина
		{
			Console.WriteLine("Оценка своего отношения к паре(от 1 до 10):");
			int ch = Convert.ToInt32(Console.ReadLine());
			double ret = -1;
			if (ch > 0 && ch < 11)
				ret = ch / 10;

			return ret;
		}

		static double SubCh()//определение коэф. полезности предмета
		{
			Console.WriteLine("Выберети с чем связана дисциплина:\n" +
							  "1.С программированием\n" +
							  "2.Гуманитарная\n" +
							  "3.С математикой\n");
			int ch = Convert.ToInt32(Console.ReadLine());
			double ret = -1;
			switch (ch)
			{
				case 1:
					ret = 0.9;
					break;

				case 2:
					ret = 0.3;
					break;

				case 3:
					ret = 0.8;
					break;

				default:
					Console.WriteLine("Ошибка");
					break;
			}
			return ret;
		}

		static void Dialog()
		{
			Console.WriteLine("_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-\n" +
			                  "Программа для определения важности пары\n" +
							  "-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_");
			double plus = 0;
			plus = SubCh();
			if(plus == -1)
				return;
			double ans = 1 * plus;

			plus = LikeCh();
			if (plus == -1)
				return;
			ans *= plus;

			plus = TimeCh();
			if (plus == -1)
				return;
			ans *= plus;

			plus = Prop();
			if (plus == -1)
				return;
			ans *= plus;

			Console.WriteLine(ans);
			if (ans > 0 && ans < 0.3)
			{
				Console.WriteLine("Можно не идти");
				return;
			}

			if (ans > 0.29 && ans < 0.55)
			{
				Console.WriteLine("Стоит пойти");
				return;
			}
			
			if(ans > 0.54 && ans < 1)
				Console.WriteLine("Точно идти");

		}

		static void Main(string[] args)
		{
			int[] k = new int[5];
			Console.WriteLine(k.Length);
		}
	}
}
