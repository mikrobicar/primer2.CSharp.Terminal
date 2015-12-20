using System;

namespace Modul02
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			//Дефиниране на променливи
			int a = 0, b = 0;
			int sum = 0;
			string program_name = "Modul02 - Примери";
			string program_version = "1.0";

			//Събиране на числа
			a = 10;
			b = 20;

			sum = a + b;

			//За програмата
			Console.WriteLine ( program_name );
			Console.WriteLine ( "Версия: " + program_version + "\n\n");

			//Писане в конзолата
			Console.Write ( a );
			Console.Write (" + ");
			Console.Write ( b );
			Console.Write (" = ");
			Console.WriteLine ( sum );

			//Допълнителни оператори
			Console.WriteLine ("\nИзползване на +=");
			a += b;
			Console.WriteLine (  a );

			Console.WriteLine ("\nИзползване на -=");
			a -= b;
			Console.WriteLine (  a );
			
			Console.WriteLine ("\nИзползване на ++");
			a ++;
			Console.WriteLine (  a );

			Console.WriteLine ("\nИзползване на --");
			a --;
			Console.WriteLine (  a );

			Console.WriteLine ("\nИзползване на *=");
			a *= b;
			Console.WriteLine (  a );
			Console.ReadKey ();

			Console.WriteLine ("\n");
			Console.Write ("Пример:7/3");
			Console.WriteLine ("\n");
			Console.WriteLine ("Стандартно делене: " + (7 / 3).ToString ()); // ->2 (7/3=2,333)
			Console.WriteLine ("Остатък от делене: " + (7 % 3).ToString ()); // ->1 (1/3=0,333)
			Console.ReadKey ();

			Console.WriteLine ("\n");
			Console.Write ("Пример-7/4");
			Console.WriteLine ("\n");
			Console.WriteLine ("Стандартно делене: " + (7 / 4).ToString ()); // ->1 (7/4=1,75)
			Console.WriteLine ("Остатък от делене: " + (7 % 4).ToString ()); // ->3 (3/4=0,75)
			Console.ReadKey ();

			Console.WriteLine ("\n");
			Console.Write ("Пример-14/4");
			Console.WriteLine ("\n");
			Console.WriteLine ("Стандартно делене: " + (14 / 4).ToString ()); // ->3 (14/4=3.5)
			Console.WriteLine ("Остатък от делене: " + (14 % 4).ToString ()); // ->2 (2/4=0,5)
			Console.ReadKey ();

			Console.WriteLine ("\n");
			Console.Write ("Пример->15/3");
			Console.WriteLine ("\n");
			Console.WriteLine ("Стандартно делене: " + (15 / 3).ToString ()); // ->5 (15/3=5)
			Console.WriteLine ("Остатък от делене: " + (15 % 3).ToString ()); // ->0 (0/0=0)
			Console.ReadKey ();

		}
	}
}
