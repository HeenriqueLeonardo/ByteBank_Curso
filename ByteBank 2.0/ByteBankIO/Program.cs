using ByteBankIO;

partial class Program
{
    static void Main(String[] args)
    {
        var enderecoDoArquivo = "contas.txt";

        using (var fluxoDeArquivo = new FileStream(enderecoDoArquivo,
            FileMode.Open, FileAccess.Read))
        {
            var leitor = new StreamReader(fluxoDeArquivo);
            while (!leitor.EndOfStream)
            {
                var linha = leitor.ReadLine();
                var contaCorrente = ConverterStringParaContaCorrente(linha);
                var msg = $"Conta número - {contaCorrente.Numero}\n" +
                    $"Agência - {contaCorrente.Agencia}\nSaldo - {contaCorrente.Saldo}\n";
                Console.WriteLine(msg);


            }
        }
        Console.ReadKey();
    }
    static ContaCorrente ConverterStringParaContaCorrente(string linha)
    {
        // agencia  numero   saldo   titular
        // 375      4644     2483.13 Jonata

        var campos = linha.Split(',');

        var agencia = campos[0];
        var numero = campos[1];
        var saldo = campos[2];
        var nomeTitular = campos[3];

        var numeroAgencia = int.Parse(agencia);
        var numeroConta = int.Parse(numero);
        var numeroSaldo = double.Parse(saldo);

        var titular = new Cliente();
        titular.Nome = nomeTitular;

        var resultado = new ContaCorrente(numeroAgencia, numeroConta);
        resultado.Depositar(numeroSaldo);
        resultado.Titular = titular;

        return resultado;
    }
}