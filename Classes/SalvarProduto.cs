using System;
using System.IO;
using CadastrodeVendaPoo.Classes;

namespace CadastroVendaPoo.classes
{

    /// <summary>
    /// A Classe possui como função salvar os produtos em um arquivo csv
    /// </summary>
    public class SalvarProduto
    {
        public string Salvar(Produto produto)
        {
            string msg = "";
            StreamWriter arquivoP = null;
            try
            {
                arquivoP = new StreamWriter("capPodutos.csv", true);
                arquivoP.WriteLine(
                               produto.Id + ";" +
                               produto.NomeProduto + ";" +
                               produto.Descricao + ";" +
                               produto.Preco
                               );
                msg = "O produto foi salvo com sucesso";
            }
            catch (Exception ex)
            {
                msg = "Ocorreu um erro ao salvar o produto" + ex.Message;
            }
            finally
            {
                arquivoP.Close();
            }

            return msg;

        }
    }
}
