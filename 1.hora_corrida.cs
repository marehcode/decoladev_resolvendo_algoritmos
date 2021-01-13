using System;
class corrida {
	static void Main() {
		int a, n, qtdPlacas = 0;
		string[] temp;

		temp = Console.ReadLine().Split();
		
		a = Convert.ToInt32(temp[0]);
		n = Convert.ToInt32(temp[1]);
		
		qtdPlacas = a * n;

		Console.WriteLine( ((Math.Ceiling(qtdPlacas * 0.1))+" "+(Math.Ceiling(qtdPlacas * 0.2))+" "+(Math.Ceiling(qtdPlacas * 0.3))+" "+(Math.Ceiling(qtdPlacas * 0.4))+" "+(Math.Ceiling(qtdPlacas * 0.5))+" "+(Math.Ceiling(qtdPlacas * 0.6))+" "+(Math.Ceiling(qtdPlacas * 0.7))+" "+(Math.Ceiling(qtdPlacas * 0.8))+" "+(Math.Ceiling(qtdPlacas * 0.9))).ToString() );
	}
}