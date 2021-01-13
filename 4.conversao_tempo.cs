using System;
class corrida {
	static void Main() {
		string horario;
		int segundosTemp, segundos, minutos, horas;

		segundosTemp = Convert.ToInt32(Console.ReadLine());

		horas = segundosTemp/3600;
		segundosTemp = segundosTemp - (horas * 3600);

		minutos = segundosTemp/60;
		segundosTemp = segundosTemp - (minutos * 60);

		segundos = segundosTemp;

		Console.WriteLine( (horas+":"+minutos+":"+segundos).ToString() );
	}
}