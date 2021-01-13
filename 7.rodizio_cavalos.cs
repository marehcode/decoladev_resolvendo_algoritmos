using System;
using System.Text.RegularExpressions;
class cavalos {
	static void Main() {
		int qtd, i, ultimoNumero; 
		string placa;

		Regex regex = new Regex(@"^[A-Z]{3}\-\d{4}$");  

		qtd = Convert.ToInt32(Console.ReadLine());

		for (i = 0; i < qtd; i++) {
			placa = Console.ReadLine();

			if (regex.IsMatch(placa)) {
				ultimoNumero = Convert.ToInt32(placa.Substring(placa.Length - 1));
				if ((ultimoNumero == 1) || (ultimoNumero == 2)) {
					Console.WriteLine("SEGUNDA");
				}
				else if ((ultimoNumero == 3) || (ultimoNumero == 4)) {
					Console.WriteLine("TERCA");
				}
				else if ((ultimoNumero == 5) || (ultimoNumero == 6)) {
					Console.WriteLine("QUARTA");
				}
				else if ((ultimoNumero == 7) || (ultimoNumero == 8)) {
					Console.WriteLine("QUINTA");
				}
				else if ((ultimoNumero == 9) || (ultimoNumero == 0)) {
					Console.WriteLine("SEXTA");
				}
				else {
					Console.WriteLine("FALHOU");
				}
			}
			else {
				Console.WriteLine("FALHA");
			}
		}		
	}
}