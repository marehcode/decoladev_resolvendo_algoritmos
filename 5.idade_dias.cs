using System;
class idade {
	static void Main() {
		int diasTemp, anos, meses, dias;

		diasTemp = Convert.ToInt32(Console.ReadLine());

		anos = diasTemp/365;
		diasTemp = diasTemp - (anos * 365);

		meses = diasTemp/30;
		diasTemp = diasTemp - (meses * 30);

		dias = diasTemp;

		Console.WriteLine(anos+ " ano(s)");
		Console.WriteLine(meses+ " mes(es)");
		Console.WriteLine(dias+ " dia(s)");
	}
}