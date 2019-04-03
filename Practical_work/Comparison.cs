using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;
/*
1.	Создать класс с несколькими свойствами.Реализовать перегрузку операторов ==, !=.
*/
namespace Practical_work
{
	public class Comparison
	{
		public int Number { set; get; }
		public string Text { set; get; }
		
		public static bool operator !=(Comparison p1, Comparison p2)
		{
			if (Int32.Equals(p1.Number, p2.Number) == true) { WriteLine("Числа равны"); }
			if (Int32.Equals(p1.Number, p2.Number) == false) { WriteLine("Числа не равны"); }			

			if (string.Equals(p1.Text, p2.Text) == true) { WriteLine("Тексты равны"); }
			if (string.Equals(p1.Text, p2.Text) == false) { WriteLine("Тексты не равны"); }

			return false;
		}
		public static bool operator ==(Comparison p1, Comparison p2)
		{
			if (Int32.Equals(p1.Number, p2.Number) == true) { WriteLine("Числа равны"); }
			if (Int32.Equals(p1.Number, p2.Number) == false) { WriteLine("Числа не равны"); }

			if (string.Equals(p1.Text, p2.Text) == true) { WriteLine("Тексты равны"); }
			if (string.Equals(p1.Text, p2.Text) == false) { WriteLine("Тексты не равны"); }

			return true;
		}
	}
}
