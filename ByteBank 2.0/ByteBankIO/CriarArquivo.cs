﻿using System.Text;
using ByteBankIO;

partial class Program
{
    static void CriarArquivo()
    {
        var localDoArquivo = "contasExportadas.csv";

        using(var fluxoDeArquivo = new FileStream(localDoArquivo,
            FileMode.Create))
        {
            var contaComoString = "465, 7895, 4785.40, Gustavo Santos";

            var encoding = Encoding.UTF8;

            var bytes = encoding.GetBytes(contaComoString);

            fluxoDeArquivo.Write(bytes, 0, bytes.Length);
        }
    }


    static void CriarArquivoComWriter()
    {
        var localDoArquivo = "contasExportadas.csv";
        using (var fluxoDeArquivo = new FileStream(localDoArquivo, FileMode.Create))
        using (var escritor = new StreamWriter(fluxoDeArquivo))
        {
            escritor.Write("456,65465,456.0,Pedro");
        }
    }

    static void EscreveTeste()
    {
        var localDoArquivo = "Teste.txt";
        using (var fluxoDeArquivo = new FileStream(localDoArquivo, FileMode.Create))
        using (var escritor = new StreamWriter(fluxoDeArquivo))
        {
            for(int i = 0; i < 10; i++)
            {
                escritor.WriteLine($"linha {i}");
                escritor.Flush();
                Console.WriteLine("(Enter) para proxima linha ...");
                Console.ReadKey();
            }
        }
    }
}
