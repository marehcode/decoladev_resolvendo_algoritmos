using System;
class corrida {
	static void Main() {
		string[] numRefeicoes, numPedidos;
		int pessoasTristes = 0, diferenca = 0;

		numRefeicoes = Console.ReadLine().Split();
		numPedidos = Console.ReadLine().Split();

		if (Convert.ToInt32(numPedidos[0]) > Convert.ToInt32(numRefeicoes[0])) {
			diferenca = Convert.ToInt32(numPedidos[0]) - Convert.ToInt32(numRefeicoes[0]);
			pessoasTristes = pessoasTristes + diferenca;
		}
		if (Convert.ToInt32(numPedidos[1]) > Convert.ToInt32(numRefeicoes[1])) {
			diferenca = Convert.ToInt32(numPedidos[1]) - Convert.ToInt32(numRefeicoes[1]);
			pessoasTristes = pessoasTristes + diferenca;
		}
		if (Convert.ToInt32(numPedidos[2]) > Convert.ToInt32(numRefeicoes[2])) {
			diferenca = Convert.ToInt32(numPedidos[2]) - Convert.ToInt32(numRefeicoes[2]);
			pessoasTristes = pessoasTristes + diferenca;
		}

		Console.WriteLine(pessoasTristes);
	}
}