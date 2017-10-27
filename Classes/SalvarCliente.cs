using System;
using System.IO;
using CadastroVendaPoo.Classes;

namespace CadastrodeVendaPoo.Classes
{
    public class SalvarCliente
    {
        public string Salvar(Cliente cliente)
        {
            string msg = "";
            StreamWriter arquivo = null;
            try
            {
                if (cpfValido(cliente.Cpf))
                {
                    arquivo = new StreamWriter("cadClientes.csv", true);
                    arquivo.WriteLine(
                                     cliente.Nome + ";" +
                                     cliente.Email + ";" +
                                     cliente.Cpf + ";" +
                                     cliente.DataCadastro);


                    msg = "Cliente Salvo com Sucesso!";
                }
                else
                {
                    msg = "CPF inválido";
                }
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
        private bool cpfValido(string CPF)
        {

            Console.Clear();
            bool retorno = true;

            string cpfCalculo = "";

            int[] v1 = { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] v2 = { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };

            int resultado = 0;
            int resto = 0;

            // Console.WriteLine("Digite o numero do CPF:");
            // cpfUsuario = Console.ReadLine();

            cpfCalculo = CPF.Substring(0, 9);

            for (int i = 0; i < cpfCalculo.Length; i++)
            {
                resultado += Int16.Parse(cpfCalculo[i].ToString()) * v1[i];
            }

            resto = resultado % 11;
            if (resto < 2)
                cpfCalculo += "0";

            else
                cpfCalculo += (11 - resto).ToString();

            resultado = 0;

            for (int i = 0; i < cpfCalculo.Length; i++)
            {
                resultado += Int16.Parse(cpfCalculo[i].ToString()) * v2[i];
            }

            resto = resultado % 11;
            if (resto < 2)
                cpfCalculo += "0";

            else
                cpfCalculo += (11 - resto).ToString();

            if (CPF != cpfCalculo)
                retorno = false;

            return retorno;


        }
    }
}