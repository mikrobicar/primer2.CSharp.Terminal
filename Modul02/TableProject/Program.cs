using System;

namespace TableProject
{
	class MainClass
	{
		public static void Main (string[] args)
		{
//
//			//Дефиниране на таблица
//			string[,] table = new string[2, 3];
//
//			//Въвеждане на първи ред
//			table[0, 0] = "Борис"; table[0, 1] = "Симеонов"; table[0, 2] = "46";
//
//			//Въвеждане на втори ред
//			table[1, 0] = "Борис"; table[1, 1] = "Симеонов"; table[1, 2] = "47";
//
//			//Печат
//			Console.Write ("Кой ред искате да видите: ");
//			int _index = Convert.ToInt32 (Console.ReadLine ()) - 1;
//			Console.WriteLine ((table [_index, 0]) [0] + ". " + table [_index, 1] + ", " + table [_index, 2] + " г.");
//
//
//			//Шах
//			string[,] shah = new String[3,3];
//			shah[1,1] = "Х";
//			Console.WriteLine (shah [1,1]);

//			int[,] a = new int [3,3]
//			{{1,2,3}, {4,5,6}, {7,8,9}};
//			Console.WriteLine(a[0,0]+" "+a[0,1]+" "+a[0,2]);
//			Console.WriteLine(a[1,0]+" "+a[1,1]+" "+a[1,2]);
//			Console.WriteLine(a[2,0]+" "+a[2,1]+" "+a[2,2]);

			string[] row = new string[3];
			row [0] = "Ред 1";
			row [1] = "Ред 2";
			row [2] = "Ред 3";

			Console.WriteLine ("Масив row:" + row [0] + ", " + row [1] + ", " + row [2] + "\n");

			string[] parse = "1,2,3,4,5,6,7,8,9".Split (',');
			Console.WriteLine ("Броят на цифрите в стринга:\n" + "1,2,3,4,5,6,7,8,9\n\ne:" + parse.Length);

			string list1 = string.Join (";", parse);
			Console.WriteLine ("Новиат стринг е:\n" + list1 + "\n\n");



		}
	}
}





	









