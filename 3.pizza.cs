using System;
class pizza {
	static void Main() {
		int pessoas, datas, qtdConfirmados = 0, opcao, boolConfirmado = 0, i, j; //datas = linhas
		string[] entrada, qtdTemp;
		string data = "Pizza antes de FdA";

		qtdTemp = Console.ReadLine().Split();

		pessoas = Convert.ToInt32(qtdTemp[0]);
		datas = Convert.ToInt32(qtdTemp[1]);

		for (i = 0; i < datas; i++) {
			entrada = Console.ReadLine().Split();
			qtdConfirmados = 0;

			for (j = 1; j <= pessoas; j++) {
				opcao = Convert.ToInt32(entrada[j]);
				if (opcao == 1) {
					qtdConfirmados++;
				}
			}
			if ((qtdConfirmados == pessoas) && (boolConfirmado == 0)) {
				data = entrada[0];
				boolConfirmado = 1;
			}
		}

		Console.WriteLine(data);
	}
}