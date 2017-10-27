using System;

namespace CadastroVendaPoo.Classes{
    public class Cliente{
        private string nome;
        private string email;
        private string cpf;

        private DateTime datadecadstro;
        public Cliente(){

            /// <summary>
            /// Constroi o objeto Cliente e voce precisa passar os dados como parametro
            /// </summary>
            /// <param name="nome">Passe o nome do cliente como texto</param>
            /// <param name="email">Passe o email do cliente como texto</param>
            /// <param name="cpf">Passe o CPF do cliente com texto</param>
            /// <param name="datacadastro">Passe a data de cadastro como DateTime</param>
            /// <returns></returns>
            
        }
        public Cliente(string nome, string email,string cpf, DateTime datacadastro){

            this.nome = nome;
            this.email = email;
            this.cpf = cpf;
            this.datadecadstro = datacadastro;  

        }
        public string Nome { get{return nome;} set{nome = value;}}
        public string Email { get{return email;} set{email = value;}}
        public string  Cpf  { get{return cpf;} set{cpf = value;} } 
        public DateTime DataCadastro  { get{return datadecadstro;} set{datadecadstro = value;} }   
        
        
    }
}