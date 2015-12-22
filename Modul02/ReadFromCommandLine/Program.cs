using System;

namespace ReadFromCommandLine
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			//Дефиниране на променливи
			int a = 5, b = 0;

			//Въвеждане на входни параметри
			Console.Write ("Моля въведете числото b: ");
			b = Convert.ToInt32 ( Console.ReadLine () );


			//Печат на ресултата
			Console.WriteLine ("\nРезултата a + b e: " + ( a + b ).ToString () + "\n");

			string test = "1";
			test += ", 2";
			test += ", 3";
			test += ", 4";
			test += ", 5";
			test += ", 6";

			Console.WriteLine ("Събиране с  += :" + test + "\n");

			test = test.Replace (", ", ";");
			Console.WriteLine ( "Работа с Replase с  += :" + test + "\n");
			Console.WriteLine ( "3-ти знак: " + test.Split (';')[2] );

			string k = "Какво правиш ?\n";
			k +=" 1.Работя:\n";
			k +=" 2.Почивам:\n";
			k +=" 3.Спортувам:\n";
			Console.WriteLine ( k );

			string l = "Какво правиш ?\n";
			Console.WriteLine (" 1.Карам кола:\n 2.Карам колело:\n 3.Карам мотор:\n");




		}
	}
}
