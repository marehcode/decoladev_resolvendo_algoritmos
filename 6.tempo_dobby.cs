using System;
class tempo {
	static void Main() {
		int n, a, b;
		string[] minutosTemp;

		n = Convert.ToInt32(Console.ReadLine());
		minutosTemp = Console.ReadLine().Split();

		a = Convert.ToInt32(minutosTemp[0]);
		b = Convert.ToInt32(minutosTemp[1]);

		if ((a + b) > n) {
			Console.WriteLine("Deixa para amanha!");
		}
		else {
			Console.WriteLine("Farei hoje!");
		}
	}
}