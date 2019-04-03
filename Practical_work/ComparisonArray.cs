using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;
/*
2.	Дан класс содержащий внутри себя массив.
Реализовать перегрузку операторов < , > так,
чтобы если сумма элементов массива 1 класса больше, возвращалось значение true и наоборот.
 */
namespace Practical_work
{
	public class ComparisonArray
	{
		const int DEFAULT_BOUND = 100;
		const int arrayRange = 10;

		public int[] mas;
		public int sum;

		public static bool operator <(ComparisonArray firstArray, ComparisonArray secondArray)
		{
			return firstArray.sum < secondArray.sum;
		}
		public static bool operator >(ComparisonArray firstArray, ComparisonArray secondArray)
		{
			return firstArray.sum > secondArray.sum;
		}

		public ComparisonArray(Random random)
		{
			mas = new int[arrayRange];
			
			for (int i = 0; i < mas.Length; i++)
			{
				mas[i] = random.Next(-DEFAULT_BOUND, DEFAULT_BOUND);
				sum += mas[i];
			}
		}
		
		public void Print()
		{
			foreach (var i in mas)
			{
				Write(i + " ");
			}
			WriteLine();
			WriteLine("Сумма элементов массива = " + sum);
		}
	}
}
