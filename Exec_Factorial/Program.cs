using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exec_Factorial
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("請輸入階層值：");
			int input = Convert.ToInt32(Console.ReadLine());
			//bool value=int.TryParse(input,out int input_);
			//int number = 6;
			int sum = new int();
			int k = 1;
			for (int i = 1; i <= input; i++)
			{

				k = k * i;

			}
			Console.WriteLine(k);

		}
	}
}
