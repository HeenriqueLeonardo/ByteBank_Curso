using System.Text;

var fs = new FileStream("teste.txt", FileMode.Open);

var buffer = new byte[1024];
var encoding = Encoding.ASCII;

var bytesLidos = fs.Read(buffer, 0, 1024);
var conteudoArquivo = encoding.GetString(buffer, 0, bytesLidos);

Console.Write(conteudoArquivo);