using ByteBankIO;
using System.Text;
using System.Text.Unicode;

var enderecoDoArquivo = "contas.txt";
var numeroDeBytesLidos = -1;

using (var fluxoDoArquivo = new FileStream(enderecoDoArquivo,
    FileMode.Open))
{
    var buffer = new byte[1024]; //1KB



    while (numeroDeBytesLidos != 0)
    {
        numeroDeBytesLidos = fluxoDoArquivo.Read(buffer, 0, 1024);
        EscreverBufffer(buffer, numeroDeBytesLidos);
        Console.WriteLine($"\nbytes lidos: {numeroDeBytesLidos} ");
    }
    fluxoDoArquivo.Close();

}



static void EscreverBufffer(byte[] buffer, int bytesLidos)
{
    var utf8 = new UTF8Encoding();

    var texto = utf8.GetString(buffer, 0, bytesLidos);

    Console.Write(texto);
   
}
