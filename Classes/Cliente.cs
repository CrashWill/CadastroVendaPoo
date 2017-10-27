using System;

namespace CadastroVendaPoo.Classes{
    public class Cliente{
        private string nome;
        private string email;
        private string cpf;

        private DateTime datadecadstro;
        public Cliente ()

        {
            
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