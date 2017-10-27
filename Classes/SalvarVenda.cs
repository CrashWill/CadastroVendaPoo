using System;
using System.IO;
using CadastroVendaPoo.Classes;

namespace CadastrodeVendaPoo.Classes
{
    public class SalvarVenda
    {
        public string SalvarV(Venda venda)
        {
            string msg = "";
            StreamWriter arquivo = null;
             try
            {
                    arquivo = new StreamWriter("cadVendas.csv", true);
                    arquivo.WriteLine(
                                     venda.Cpf + ";" +
                                     venda.Id + ";" +
                                     venda.datavenda);



                    msg = "Venda Salva com Sucesso!";
                           }
            catch (Exception ex)
            {
                msg = "Erro ao tentar gravar o arquivo." + ex.Message;
            }
            finally
            {
                arquivo.Close();
            }
            return msg;

        }
    }
}

        