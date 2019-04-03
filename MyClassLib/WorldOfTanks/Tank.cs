using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/*
 Перегрузка операторов

Разработать программу, моделирующую танковый бой. 
В танковом бою участвуют 5 танков «Т-34» и 5 танков «Pantera».
Каждый танк («Т-34» и «Pantera») описываются параметрами: 
«Боекомплект», «Уровень брони», «Уровень маневренности». 
Значение данных параметров задаются случайными числами от 0 до 100.
Каждый танк участвует в парной битве, т.е. первый танк «Т-34» сражается с первым танком «Pantera» и т. д.
Победа присуждается тому танку, который превышает противника
по двум и более параметрам из трех (пример: см. программу).
Основное требование: сражение (проверку
на победу в бою) реализовать путем перегрузки оператора «*» (произведение). 
1.	В решение добавить новый проект с именем «Day7 (Tanks)»,
в котором будут промоделированы танковые сражения.
В данный проект добавить ссылку на библиотеку классов «MyClassLib».
2.	В библиотеке классов «MyClassLib» создать папку «WordOfTanks», а в ней разработать класс с именем «Tank».
В классе должно быть реализовано
●	Поля
закрытые поля, предназначенные для представления
1.	Названия танка.
2.	Уровня боекомплекта танка.
3.	Уровня брони. 
4.	Уровня маневренности.
●	Конструктор
Конструктор с параметрами, обеспечивающий инициализацию всех полей класса Tank.
При этом Боекомплект, Уровень брони, Уровень маневренности инициализируются
случайными числами от 0 до 100 %. Название танка передаются в конструктор из функции Main(). 
●	Перегрузка оператора «^»(произведение)
При перегрузке оператора «^» (произведение) должна быть
реализована проверка на победу в бою одного танка по отношению к другому.
Критерий победы — победивший танк должен превышать проигравший
танк не менее чем по двум из трех параметров (Боекомплект, Уровень брони, Уровень маневренности). 
●	Методы:
Получение текущих значений параметров танка: Бое­комплект, Уровень брони, Уровень маневренности в виде строки.

Важно! При разработке программы использовать обработку исключительных ситуаций.
Варианты возможных исключительных ситуаций рассмотреть самостоятельно!
 */
namespace MyClassLib.WorldOfTanks
{
	public class Tank
	{
		private string _tankName;
		private int _ammunition;
		private int _armor;
		private int _agility;
		
		public Tank(string tankName)
		{
			System.Threading.Thread.Sleep(50);
			Random random = new Random();
			_tankName = tankName;
			_ammunition = random.Next(0, 100);
			_armor = random.Next(0, 100);
			_agility = random.Next(0, 100);
		}
		public void Print()
		{
			Console.WriteLine($"Name       : {_tankName}\nAmmunition :" +
				$" {_ammunition}\nArmor      : {_armor}\nAgility    : {_agility}");
			Console.WriteLine("--------------------");
		}

		public static string operator *(Tank firstTank, Tank secondTank)
		{
			int Counter = 0;
			try
			{
				if (firstTank._tankName == null || secondTank._tankName == null)
					throw new Exception("Названия танков не заданы!");
				else
				{
					if (firstTank._ammunition > secondTank._ammunition)
					{
						Counter++;
					}
					if (firstTank._armor > secondTank._armor)
					{
						Counter++;
					}
					if (firstTank._agility > secondTank._agility)
					{
						Counter++;
					}
					if (Counter > 1) { return "\nOur T-34 win!"; }
					else { return "\nEnemy's Pantera win!"; }
				}
			}
			catch (Exception exception)
			{
				Console.WriteLine($"Возникло исключение: {exception.Message}");
				return "Танк не найден!\n";
			}
		}
	}
}