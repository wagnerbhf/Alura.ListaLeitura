using System.IO;

namespace Alura.ListaLeitura.App.Html
{
    public class HtmlUtil
    {
        public static string CarregarArquivoHtml(string nomeArquivo)
        {
            var nomeCompletoArquivo = $"Html/{nomeArquivo}.html";

            using (var arquivo = File.OpenText(nomeCompletoArquivo))
            {
                return arquivo.ReadToEnd();
            }
        }
    }
}