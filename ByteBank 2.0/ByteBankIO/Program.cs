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
                var line = leitor.ReadLine();
                Console.WriteLine(line);


            }
        }
        Console.ReadKey();
    }
}