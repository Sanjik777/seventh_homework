using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;
/*
Перегрузка операторов

1.	Создать класс с несколькими свойствами. Реализовать перегрузку операторов ==, !=.
2.	Дан класс содержащий внутри себя массив.
Реализовать перегрузку операторов < , > так,
чтобы если сумма элементов массива 1 класса больше, возвращалось значение true и наоборот.
 */
namespace Practical_work
{
	class Program
	{
		static void Main(string[] args)
		{
			WriteLine("\n----------------1------------------\n");
			Comparison firstClass = new Comparison { Number = 2, Text = "asd" };
		    Comparison secondClass = new Comparison { Number = 3, Text = "asd" };			
			if (firstClass == secondClass) { WriteLine(); }

			WriteLine("\n----------------2------------------\n");
			Random random = new Random();
			ComparisonArray firstArray = new ComparisonArray(random);
			ComparisonArray secondArray = new ComparisonArray(random);
			WriteLine("Первый массив: ");
			firstArray.Print();
			WriteLine("\nВторой массив: ");
			secondArray.Print();

			if (firstArray > secondArray) { WriteLine("\nСумма первого массива больше"); }
			else { WriteLine("\nСумма первого массива меньше"); }

			ReadKey();
		}
	}
}
